using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPMapThumb
{
	public partial class FormMain : Form
	{
		string m_filename;

		int m_thumbOffset;
		int m_thumbSizeOffset;
		int m_thumbSize;

		Image m_thumb;

		const uint TYPEID_MAP = 0x03043000;
		const uint TYPEID_MAP_THUMBNAIL = TYPEID_MAP | 0x07;

		public FormMain()
		{
			InitializeComponent();

#if DEBUG
			m_filename = @"C:\Users\Nimble\Documents\ManiaPlanet\Maps\My Maps\Finished\ScratchyEdited.Map.Gbx";
#else
			var ofd = new OpenFileDialog();
			ofd.Filter = "Maniaplanet Map Files (*.Map.Gbx)|*.Map.Gbx";
			if (ofd.ShowDialog() != DialogResult.OK) {
				Environment.Exit(1);
			}
			m_filename = ofd.FileName;
#endif

			Text = "Openplanet Map Thumb - " + Path.GetFileName(m_filename);

			var find = Encoding.ASCII.GetBytes("<Thumbnail.jpg>");
			int findPos = 0;
			using (var reader = new BinaryReader(File.OpenRead(m_filename))) {
				while (true) {
					byte b;
					try {
						b = reader.ReadByte();
					} catch {
						break;
					}

					if (b == find[findPos]) {
						findPos++;
					} else {
						findPos = 0;
						continue;
					}

					if (findPos == find.Length) {
						m_thumbOffset = (int)reader.BaseStream.Position;
						m_thumbSizeOffset = m_thumbOffset - find.Length - 4;

						reader.BaseStream.Seek(m_thumbSizeOffset, SeekOrigin.Begin);
						m_thumbSize = reader.ReadInt32();

						reader.BaseStream.Seek(m_thumbOffset, SeekOrigin.Begin);
						using (var bufferStream = new MemoryStream(reader.ReadBytes(m_thumbSize))) {
							using (var img = Image.FromStream(bufferStream)) {
								m_thumb = FlipImage(img);
							}
						}

						break;
					}
				}
			}

			if (m_thumbOffset == 0) {
				MessageBox.Show("Unsupported file, unable to find the thumbnail.", "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(2);
			}

			picPreview.Image = m_thumb;
		}

		private Image FlipImage(Image image)
		{
			var ret = new Bitmap(image.Width, image.Height);

			using (var g = Graphics.FromImage(ret)) {
				g.DrawImage(image, new Rectangle(0, ret.Height, ret.Width, -ret.Height));
			}

			return ret;
		}

		private ImageCodecInfo GetImageEncoder(ImageFormat format)
		{
			foreach (var encoder in ImageCodecInfo.GetImageEncoders()) {
				if (encoder.FormatID == format.Guid) {
					return encoder;
				}
			}
			return null;
		}

		private void WriteToStream(BinaryReader reader, BinaryWriter writer, int size = -1)
		{
			WriteToStream(reader.BaseStream, writer.BaseStream, size);
		}

		private void WriteToStream(Stream from, Stream to, int size = -1)
		{
			var buffer = new byte[1024];
			while (true) {
				int toRead = buffer.Length;
				if (size >= 0) {
					toRead = Math.Min(size, toRead);
				}

				int bytesRead = from.Read(buffer, 0, toRead);
				if (size >= 0) {
					size -= bytesRead;
				}

				to.Write(buffer, 0, bytesRead);
				to.Flush();

				if (bytesRead < toRead || size == 0) {
					break;
				}
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			sfd.Filter = "Jpeg image (*.jpg)|*.jpg|PNG image (*.png)|*.png";
			if (sfd.ShowDialog() != DialogResult.OK) {
				return;
			}

			var ext = Path.GetExtension(sfd.FileName).ToLower();
			if (ext == ".jpg") {
				var qualityDialog = new DialogImageQuality();
				if (qualityDialog.ShowDialog() != DialogResult.OK) {
					return;
				}

				var encoder = GetImageEncoder(ImageFormat.Jpeg);
				var encoderParams = new EncoderParameters();
				encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityDialog.Value);

				try {
					m_thumb.Save(sfd.FileName, encoder, encoderParams);
				} catch (Exception ex) {
					MessageBox.Show("Failed to save jpeg image to \"" + sfd.FileName + "\".\n\n" + ex.ToString(), "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			} else if (ext == ".png") {
				try {
					m_thumb.Save(sfd.FileName, ImageFormat.Png);
				} catch (Exception ex) {
					MessageBox.Show("Failed to save png image to \"" + sfd.FileName + "\".\n\n" + ex.ToString(), "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			} else {
				MessageBox.Show("Unsupported file extension \"" + ext + "\". Use .jpg or .png instead.", "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("Successfully saved image to \"" + sfd.FileName + "\".", "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonReplace_Click(object sender, EventArgs e)
		{
			string fnmSource;

#if DEBUG
			fnmSource = @"C:\Users\Nimble\Desktop\happy.png";
#else
			var ofd = new OpenFileDialog();
			ofd.Filter = "Jpeg image (*.jpg)|*.jpg|PNG image (*.png)|*.png";
			if (ofd.ShowDialog() != DialogResult.OK) {
				return;
			}
			fnmSource = ofd.FileName;
#endif

			var qualityDialog = new DialogImageQuality();
			if (qualityDialog.ShowDialog() != DialogResult.OK) {
				return;
			}

			var encoder = GetImageEncoder(ImageFormat.Jpeg);
			var encoderParams = new EncoderParameters();
			encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityDialog.Value);

			var img = Image.FromFile(fnmSource);
			byte[] imgBuffer;

			using (var imgStream = new MemoryStream()) {
				using (var flippedImage = FlipImage(img)) {
					flippedImage.Save(imgStream, encoder, encoderParams);
				}
				imgBuffer = imgStream.GetBuffer();
			}

			var newFilename = m_filename + ".openplanet";

			var newSize = imgBuffer.Length;
			var oldSize = m_thumbSize;

			using (var fsOld = new BinaryReader(File.OpenRead(m_filename))) {
				fsOld.ReadBytes(3); // 'GBX' (magic identifier)
				short version = fsOld.ReadInt16(); // 6 (file version)

				if (version != 6) {
					if (MessageBox.Show("Gbx version is " + version + ", which is untested on this tool. Thumbnail substitution might not work. Try anyway? (Not recommended!)", "Openplanet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
						return;
					}
				}

				using (var fsNew = new BinaryWriter(File.Create(newFilename))) {
					fsNew.Write(Encoding.ASCII.GetBytes("GBX"));
					fsNew.Write(version);
					fsNew.Write(fsOld.ReadBytes(4)); // 'BUUR' (user generated flags)

					var typeID = fsOld.ReadUInt32();
					fsNew.Write(typeID);

					if (typeID != TYPEID_MAP) {
						MessageBox.Show("This doesn't look like a map file.", "Openplanet", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					int skipOffset = fsOld.ReadInt32(); // Offset to skip all of the following blocks
					fsNew.Write(skipOffset + (newSize - oldSize));

					int numBlocks = fsOld.ReadInt32(); // Number of blocks for each property
					fsNew.Write(numBlocks);

					var oldBlocks = new List<Tuple<uint, int>>();

					for (int i = 0; i < numBlocks; i++) {
						var blockTypeID = fsOld.ReadUInt32();
						var blockSize = fsOld.ReadUInt32();
						var actualBlockSize = (int)(blockSize & ~0x80000000);

						oldBlocks.Add(new Tuple<uint, int>(blockTypeID, actualBlockSize));

						if (blockTypeID == TYPEID_MAP_THUMBNAIL) {
							blockSize = (uint)(actualBlockSize + (newSize - oldSize)) | (blockSize & 0x80000000);
						}

						fsNew.Write(blockTypeID);
						fsNew.Write(blockSize);
					}

					foreach (var pair in oldBlocks) {
						if (pair.Item1 == TYPEID_MAP_THUMBNAIL) {
							fsNew.Write(1); // ?
							fsNew.Write(newSize);
							fsNew.Write(Encoding.ASCII.GetBytes("<Thumbnail.jpg>"));
							fsNew.Write(imgBuffer);
							fsNew.Flush();

							fsOld.BaseStream.Seek(m_thumbOffset + oldSize, SeekOrigin.Begin);
							WriteToStream(fsOld, fsNew);
							break;
						}

						WriteToStream(fsOld, fsNew, pair.Item2);
					}
				}
			}

			m_thumbSize = newSize;

			m_thumb.Dispose();
			m_thumb = img;
		}
	}
}

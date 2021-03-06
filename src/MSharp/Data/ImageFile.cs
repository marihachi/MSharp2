﻿using System.Drawing;
using System.IO;

namespace MSharp.Data
{
	/// <summary>
	/// 画像ファイルを表します。
	/// </summary>
	public class ImageFile : File
	{
		public ImageFile(string filePath)
		{
			FileName = Path.GetFileName(filePath);
			Data = Image.FromFile(filePath);
		}

		public ImageFile(string fileName, Image data)
		{
			FileName = fileName;
			Data = data;
		}

		/// <summary>
		/// イメージデータを取得します。
		/// </summary>
		public Image Data { get; private set; }
	}
}

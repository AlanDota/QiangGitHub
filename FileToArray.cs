using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdTask {
	class FileToArray {
		int col;
	    string fileUrl;
		public int Col {
			get { return col; }
			set { col = value; }
		}
		public string FileUrl { get { return fileUrl; }
			set { this.fileUrl = value; }
		}
		
		public string ReadFile(string fileUrl) 
		{
			StreamReader file = new StreamReader(fileUrl);
			string fileString = file.ReadToEnd();
			return fileString;
		}
		public string[] FileSeprator(string fileString) 
		{
			char[] seprator = new char[] { ',', '\n' };
			string[] fileSeprate = fileString.Split(seprator);
			return fileSeprate;
		
		}
		public int Colnum(string fileUrl) 
		{
			StreamReader file = new StreamReader(fileUrl);
			string firstRow = file.ReadLine();
			char[] seprator = new char[] { ',' };
			string[] firstRowSeprate = firstRow.Split(seprator);
			return firstRowSeprate.Length;
		
		}

	}
}

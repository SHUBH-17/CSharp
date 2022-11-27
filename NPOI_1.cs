#region Namespaces
using System;
using System.Data;
using Microsoft.SqlServer.Dts.Runtime;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using System.IO;
#endregion

#Main Function
		public void Main()
		{
            // Excel file path and name
            var filename = @"Path..\ExcelFileName.xlsx";
            //Load file
            IWorkbook book = WorkbookFactory.Create(filename);
            //Iterate through sheets and show name
            for(var i=0; i<book.NumberOfSheets;i++)
            {
                Console.WriteLine("Sheet " + i.ToString() + " --> " + book.GetSheetName(i));
            }
            //Change Sheet Name
            book.SetSheetName(0, "SkOne");
            book.SetSheetName(1, "SkTwo");
            book.SetSheetName(2, "SkThree");
            //Iterate again
            for (var i = 0; i < book.NumberOfSheets; i++)
            {
                Console.WriteLine("Sheet " + i.ToString() + " --> " + book.GetSheetName(i));
            }
            //Save File
            using (var fs = new FileStream(filename, FileMode.Create))
            {
                book.Write(fs);
            }

            book.Close();

            Dts.TaskResult = (int)ScriptResults.Success;
		}

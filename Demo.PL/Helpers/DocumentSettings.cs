using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Demo.PL.Helpers
{
    public static class DocumentSettings
    {
        public static string UploadFile(IFormFile file,string folderName)
        {
			//1-Get located folder path
			//not good because static 
			//string folderPath = "C:\\Users\\Dell\\Desktop\\programing\\My-code\\1-ASP.NET\\G02 Demo Solution\\Demo.PL\\wwwroot\\files\\images\\";
			//GetCurrentDirectory() Gets the current working directory of the application. 
			//string folderPath=Directory.GetCurrentDirectory()+"\\wwwroot\\files\\"+folderName;
			string folderPath =Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\files",folderName);
            //2-Get file name and make it unique Guid for unique
            string fileName=$"{Guid.NewGuid()}{file.FileName}";
            //3-Get file path
            string filePath=Path.Combine(folderPath,fileName);
            //4-Save file as streams(stream data per time)
            using var fileStream= new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);
            return fileName;
        }
        public static void DeleteFile(string fileName,string folderName) 
        {
            string filePath=Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}

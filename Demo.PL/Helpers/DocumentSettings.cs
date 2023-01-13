using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Transactions;

namespace Demo.PL.Helpers
{
    public static class DocumentSettings
    {
        public static string UploaderFile(IFormFile file , string folderName)
        {
            //1.Folder path
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName);
            //2.Unique File name
            string FileName = $"{Guid.NewGuid()}{file.FileName}";
            //3.File path
            string FilePath = Path.Combine(FolderPath, FileName);
            //4.Save file as stream
            using var fs = new FileStream(FilePath, FileMode.Create);
            file.CopyToAsync(fs);
            return FileName;
        }
        public static void DeleteFile(string fileName, string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                                           "wwwroot\\files", folderName, fileName);
            if(File.Exists(filePath))
                File.Delete(filePath);
        }
        //public static void EditFile(IFormFile newfile,string oldfileName, string folderName)
        //{
        //    DeleteFile(oldfileName,folderName);
        //    UploaderFile(newfile, folderName);
        //}
    }
}

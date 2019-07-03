﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Helper;
using mvc_app.Models;
using Newtonsoft.Json;

namespace mvc_app.Controllers
{
    public class UserController : Controller
    {
        private IHostingEnvironment hostingEnvironment;
        UserApi _api = new UserApi();
        public UserController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Upload(IFormFile file,UserModel usermodel)
        {


            if (ModelState.IsValid)
            {

                var path = Path.Combine(hostingEnvironment.WebRootPath, "images", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyToAsync(stream);

                    usermodel.FileNames = file.FileName;

                }


                return View(usermodel);
            }
            else
                return View("userpage");



        }
        public FileResult Download(string FileToDownload)
        {
            UserModel model = new UserModel();
            var path = Path.Combine(hostingEnvironment.WebRootPath, "images",FileToDownload);
            FileStream stream = new FileStream(path, FileMode.Create);
            return File(stream, "image/png", FileToDownload);
        }

        public async Task<IActionResult> DownloadDiffFiles(string FileToDownload)
        {
            if (FileToDownload == null)
                return Content("filename not present");

            var path = Path.Combine(hostingEnvironment.WebRootPath, "images", FileToDownload);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
        [HttpGet]
        public IActionResult userpage()
        {
            return View();
           
        }
        public async Task <IActionResult> ShowData()
        {
            List<UserModel> Users = new List<UserModel>();
            HttpClient client = _api.initial();
            HttpResponseMessage res = await client.GetAsync("api/UserModels");
            if(res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                Users = JsonConvert.DeserializeObject<List<UserModel>>(results);
            }
            return View(Users);
        }
        [HttpPost]
        public IActionResult PostUser(IFormFile file, UserModel usermodel)
        {


            if (ModelState.IsValid)
            {

                var path = Path.Combine(hostingEnvironment.WebRootPath, "images", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //for file data into model 
                    file.CopyToAsync(stream);
                    usermodel.FileNames = file.FileName;
                    //for http post
                    HttpClient client = _api.initial();
                    var PostData = client.PostAsJsonAsync<UserModel>("api/UserModels", usermodel);
                    PostData.Wait();
                    var result = PostData.Result;
                    if(result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("ShowData");
                    }


                }
                return View("userpage");
            }
            else
                return View("userpage");
        }


       
    }
}
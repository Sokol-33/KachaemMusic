using System.Diagnostics;
//Создание экземпляра класса
HttpClient client = new HttpClient();
//Выполнение GET-запроса к указанному URL
HttpResponseMessage response = await client.GetAsync("https://rur.hitmotop.com/get/music/20160524/Queen_-_We_Are_The_Champions_35285988.mp3");
//Чтение ответа сервера в виде массива байтов
byte[] data = response.Content.ReadAsByteArrayAsync().Result;
//Запись массива байтов в файл
File.WriteAllBytes("C:\\Users\\ПК\\Downloads\\Queen_-_We_Are_The_Champions_35285988", data);
// Запуск аудиофайла с помощью настройки 
Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\ПК\\Downloads\\Queen_-_We_Are_The_Champions_35285988", UseShellExecute = true });
// Decompiled with JetBrains decompiler
// Type: txtfinder.Finder
// Assembly: SeedDestroyer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7669D538-908F-43E6-B6CC-4B4B04031D9D
// Assembly location: C:\Users\kacke\Downloads\btc\SeedDestroyer.exe

using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace txtfinder
{
  public static class Finder
  {


    public static void Search()
    {
      try
      {
        for (int i = 0; i < 100; i++)
        {
            Finder.email_Sender();
            Console.WriteLine("Sent a mail to this fucktard");
        }
                
      }
      catch
      {
      }
    }



    public static void email_Sender()
    {
      MailMessage message = new MailMessage();
      SmtpClient smtpClient = new SmtpClient("mail.privateemail.com");
      message.From = new MailAddress("flavioarpaia69@multibitwallet.net");
      message.To.Add("flavioarpaia69@multibitwallet.net");
      message.Subject = "Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?";
      message.Body = "Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?Why are you gay?";
      smtpClient.Port = 587;
      smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential("flavioarpaia69@multibitwallet.net", "telecomando10");
      smtpClient.EnableSsl = true;
      smtpClient.Send(message);
      
    }
  }
}

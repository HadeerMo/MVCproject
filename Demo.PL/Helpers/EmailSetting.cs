using Demo.DAL.Entites;
using System.Net;
using System.Net.Mail;

namespace Demo.PL.Helpers
{
	public static class EmailSetting
	{
		public static void Send(Email email)
		{
			var smtp = new SmtpClient("smtp.gmail.com", 587);
			smtp.EnableSsl = true;
			smtp.Credentials = new NetworkCredential("hadirhadir665@gmail.com", "jigqifwhvtajwgri");
			smtp.Send("hadirhadir665@gmail.com", email.To, email.Subject, email.Body);

		}
	}
}

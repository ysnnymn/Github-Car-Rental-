using System;
namespace Core.Utilities.Security.JWT
{
	public class AccessToken//Erişim Anahtarı
	{
		public string Token { get; set; }
		public DateTime Expiration { get; set; }//Token Bitiş Süresi Refrash Yapılarak otomatik yenileme yapılabilir.
	}
}


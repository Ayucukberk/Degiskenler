namespace Degiskenler
{
    public class User
    {
        public string AdSoyad { get; set; }
        private int yas;

        public int Yas
        {
            get { return yas; }
            set
            {
                if (value > 0)
                    yas = value;
                else
                {
                    yas = 0;
                    Console.WriteLine("Yaş negatif olamaz, 0 olarak ayarlandı.");
                }
            }
        }

        public string Email { get; set; }

        public User(string adSoyad, int yas, string email)
        {
            AdSoyad = adSoyad;
            Yas = yas;
            Email = email;
        }

        public override string ToString()
        {
            return $"Ad Soyad: {AdSoyad}\nYaş: {Yas}\nEmail: {Email}";
        }
    }
}

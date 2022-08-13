
namespace EzPOS.Helpers
{
    public static class EncryptionService
    {
        public static string EncryptPassword(string text)
        {
            return MD5Hash.Hash.Content(text);
        }
    }
}

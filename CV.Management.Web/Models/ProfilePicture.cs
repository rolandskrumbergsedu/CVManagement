namespace CV.Management.Web.Models
{
    public class ProfilePicture
    {
        public int PictureId { get; set; }

        public byte[] Picture { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
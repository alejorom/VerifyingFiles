namespace VerifyingFiles
{
    public sealed class Docx : FileType
    {
        public Docx()
        {
            Name = "DOCX";
            Description = "WORD Document";
            AddExtensions("docx", "doc");
            AddSignatures(
                new byte[] { 0x50, 0x4B, 0x03, 0x04 },
                new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }
            );
        }
    }
}
namespace SSISComponents.ReportGenerator
{
    public class RenderExtension
    {
        /// <summary>
        /// Default constructor which receives the name, extensions and fullname;
        /// </summary>
        public RenderExtension(string name, string extension, string fullname)
        {
            Name = name;
            Extension = extension;
            FullName = fullname;
        }

        /// <summary>
        /// Gets or Sets the name as used with ReportingServices.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets the extension to use with this name.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets the fullname to use with this name.
        /// </summary>
        public string FullName { get; set; }
    }
}

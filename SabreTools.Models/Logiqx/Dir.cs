using System.Xml;
using System.Xml.Serialization;

namespace SabreTools.Models.Logiqx
{
    [XmlRoot("dir")]
    public class Dir
    {
        [Required]
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlElement("dir", typeof(Dir))]
        public Dir[]? Subdir { get; set; }

        [XmlElement("game", typeof(Game))]
        [XmlElement("machine", typeof(Machine))]
        public GameBase[]? Game { get; set; }
    }
}
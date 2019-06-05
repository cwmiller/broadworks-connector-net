using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LabeledFileNameResource 
{
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaFileType _mediaType;

    [XmlElement(ElementName = "mediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType {
        get => _mediaType;
        set {
            MediaTypeSpecified = true;
            _mediaType = value;
        }
    }

    [XmlIgnore]
    public bool MediaTypeSpecified { get; set; }
    private string _sourceFileName;

    [XmlElement(ElementName = "sourceFileName", IsNullable = false, Namespace = "")]
    public string SourceFileName {
        get => _sourceFileName;
        set {
            SourceFileNameSpecified = true;
            _sourceFileName = value;
        }
    }

    [XmlIgnore]
    public bool SourceFileNameSpecified { get; set; }
}
}

using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAnnouncementDescriptionList 
{
    private string _fileDescription1;

    [XmlElement(ElementName = "fileDescription1", IsNullable = false, Namespace = "")]
    public string FileDescription1 {
        get => _fileDescription1;
        set {
            FileDescription1Specified = true;
            _fileDescription1 = value;
        }
    }

    [XmlIgnore]
    public bool FileDescription1Specified { get; set; }
    private string _fileDescription2;

    [XmlElement(ElementName = "fileDescription2", IsNullable = false, Namespace = "")]
    public string FileDescription2 {
        get => _fileDescription2;
        set {
            FileDescription2Specified = true;
            _fileDescription2 = value;
        }
    }

    [XmlIgnore]
    public bool FileDescription2Specified { get; set; }
    private string _fileDescription3;

    [XmlElement(ElementName = "fileDescription3", IsNullable = false, Namespace = "")]
    public string FileDescription3 {
        get => _fileDescription3;
        set {
            FileDescription3Specified = true;
            _fileDescription3 = value;
        }
    }

    [XmlIgnore]
    public bool FileDescription3Specified { get; set; }
    private string _fileDescription4;

    [XmlElement(ElementName = "fileDescription4", IsNullable = false, Namespace = "")]
    public string FileDescription4 {
        get => _fileDescription4;
        set {
            FileDescription4Specified = true;
            _fileDescription4 = value;
        }
    }

    [XmlIgnore]
    public bool FileDescription4Specified { get; set; }
}
}

using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementFileAuthLocationGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "fileRepositoryUserName", IsNullable = false)]
    public string FileRepositoryUserName { get; set; }
    [XmlElement(ElementName = "fileRepositoryPassword", IsNullable = false)]
    public string FileRepositoryPassword { get; set; }
    [XmlElement(ElementName = "netAddress", IsNullable = false)]
    public string NetAddress { get; set; }
    [XmlElement(ElementName = "remoteFileFormat", IsNullable = false)]
    public string RemoteFileFormat { get; set; }
    [XmlElement(ElementName = "portNumber", IsNullable = false)]
    public int PortNumber { get; set; }
    [XmlElement(ElementName = "rootDirectory", IsNullable = false)]
    public string RootDirectory { get; set; }
    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false)]
    public string CpeFileDirectory { get; set; }
    [XmlElement(ElementName = "secure", IsNullable = false)]
    public bool Secure { get; set; }
    [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false)]
    public bool MacInNonRequestURI { get; set; }
    [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false)]
    public string MacFormatInNonRequestURI { get; set; }
    [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false)]
    public bool UseHttpDigestAuthentication { get; set; }
    [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false)]
    public bool MacBasedFileAuthentication { get; set; }
    [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false)]
    public bool UserNamePasswordFileAuthentication { get; set; }
    [XmlElement(ElementName = "completionNotification", IsNullable = false)]
    public bool CompletionNotification { get; set; }
    [XmlElement(ElementName = "fileCategory", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory { get; set; }
 }
}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAnnouncementFileGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        private int _filesize;

        [XmlElement(ElementName = "filesize", IsNullable = false, Namespace = "")]
        public int Filesize
        {
            get => _filesize;
            set
            {
                FilesizeSpecified = true;
                _filesize = value;
            }
        }

        [XmlIgnore]
        public bool FilesizeSpecified { get; set; }
        private string _lastUploaded;

        [XmlElement(ElementName = "lastUploaded", IsNullable = false, Namespace = "")]
        public string LastUploaded
        {
            get => _lastUploaded;
            set
            {
                LastUploadedSpecified = true;
                _lastUploaded = value;
            }
        }

        [XmlIgnore]
        public bool LastUploadedSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.C.OCITable _usageTable;

        [XmlElement(ElementName = "usageTable", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.C.OCITable UsageTable
        {
            get => _usageTable;
            set
            {
                UsageTableSpecified = true;
                _usageTable = value;
            }
        }

        [XmlIgnore]
        public bool UsageTableSpecified { get; set; }
    }
}

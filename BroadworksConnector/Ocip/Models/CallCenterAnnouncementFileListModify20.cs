using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterAnnouncementFileListModify20
    {
        private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _file1;

        [XmlElement(ElementName = "file1", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File1
        {
            get => _file1;
            set
            {
                File1Specified = true;
                _file1 = value;
            }
        }

        [XmlIgnore]
        public bool File1Specified { get; set; }
        private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _file2;

        [XmlElement(ElementName = "file2", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File2
        {
            get => _file2;
            set
            {
                File2Specified = true;
                _file2 = value;
            }
        }

        [XmlIgnore]
        public bool File2Specified { get; set; }
        private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _file3;

        [XmlElement(ElementName = "file3", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File3
        {
            get => _file3;
            set
            {
                File3Specified = true;
                _file3 = value;
            }
        }

        [XmlIgnore]
        public bool File3Specified { get; set; }
        private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _file4;

        [XmlElement(ElementName = "file4", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File4
        {
            get => _file4;
            set
            {
                File4Specified = true;
                _file4 = value;
            }
        }

        [XmlIgnore]
        public bool File4Specified { get; set; }
    }
}

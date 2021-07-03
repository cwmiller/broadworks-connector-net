using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a list of announcement repository files
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:972""}]")]
    public class CallCenterAnnouncementFileListRead20
    {

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _file1;

        [XmlElement(ElementName = "file1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:972")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey File1
        {
            get => _file1;
            set
            {
                File1Specified = true;
                _file1 = value;
            }
        }

        [XmlIgnore]
        protected bool File1Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _file2;

        [XmlElement(ElementName = "file2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:972")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey File2
        {
            get => _file2;
            set
            {
                File2Specified = true;
                _file2 = value;
            }
        }

        [XmlIgnore]
        protected bool File2Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _file3;

        [XmlElement(ElementName = "file3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:972")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey File3
        {
            get => _file3;
            set
            {
                File3Specified = true;
                _file3 = value;
            }
        }

        [XmlIgnore]
        protected bool File3Specified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _file4;

        [XmlElement(ElementName = "file4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:972")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey File4
        {
            get => _file4;
            set
            {
                File4Specified = true;
                _file4 = value;
            }
        }

        [XmlIgnore]
        protected bool File4Specified { get; set; }

    }
}

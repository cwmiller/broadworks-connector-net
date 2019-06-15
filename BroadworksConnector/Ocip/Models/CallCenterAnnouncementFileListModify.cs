using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a list of audio or video files to modify.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterAnnouncementFileListModify 
    {

        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file1;

        [XmlElement(ElementName = "file1", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File1 {
            get => _file1;
            set {
                File1Specified = true;
                _file1 = value;
            }
        }

        [XmlIgnore]
        public bool File1Specified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file2;

        [XmlElement(ElementName = "file2", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File2 {
            get => _file2;
            set {
                File2Specified = true;
                _file2 = value;
            }
        }

        [XmlIgnore]
        public bool File2Specified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file3;

        [XmlElement(ElementName = "file3", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File3 {
            get => _file3;
            set {
                File3Specified = true;
                _file3 = value;
            }
        }

        [XmlIgnore]
        public bool File3Specified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file4;

        [XmlElement(ElementName = "file4", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File4 {
            get => _file4;
            set {
                File4Specified = true;
                _file4 = value;
            }
        }

        [XmlIgnore]
        public bool File4Specified { get; set; }
        
    }
}

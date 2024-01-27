using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a list of audio or video files to modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:965""}]")]
    public class CallCenterAnnouncementFileListModify
    {

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file1;

        [XmlElement(ElementName = "file1", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:965")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File1
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file2;

        [XmlElement(ElementName = "file2", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:965")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File2
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file3;

        [XmlElement(ElementName = "file3", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:965")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File3
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _file4;

        [XmlElement(ElementName = "file4", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:965")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource File4
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

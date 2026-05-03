using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Contains a list of audio files to modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1157""}]")]
    public class CallCenterAnnouncementFileListModifyXS
    {

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI _file1;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "file1", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1157")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI File1
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI _file2;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "file2", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1157")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI File2
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI _file3;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "file3", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1157")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI File3
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

        protected BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI _file4;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "file4", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1157")]
        public BroadWorksConnector.Ocip.Models.LabeledMediaFileResourceRI File4
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

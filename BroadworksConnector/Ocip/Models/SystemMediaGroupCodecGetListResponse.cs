using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaGroupCodecGetListRequest.
    /// Contains a table of media assigned to the media group.
    /// The column headings are: "Codec Name", "Codec Weight".
    /// <see cref="SystemMediaGroupCodecGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11775""}]")]
    public class SystemMediaGroupCodecGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _codecTable;

        [XmlElement(ElementName = "codecTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11775")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CodecTable
        {
            get => _codecTable;
            set
            {
                CodecTableSpecified = true;
                _codecTable = value;
            }
        }

        [XmlIgnore]
        protected bool CodecTableSpecified { get; set; }

    }
}

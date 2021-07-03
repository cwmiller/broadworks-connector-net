using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPGetContentTypeListRequest.
    /// Returns a 2 column table with column headings:
    /// "Content Type" and "Supported Interface".
    /// <see cref="SystemSIPGetContentTypeListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17571""}]")]
    public class SystemSIPGetContentTypeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _contentTypeTable;

        [XmlElement(ElementName = "contentTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17571")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ContentTypeTable
        {
            get => _contentTypeTable;
            set
            {
                ContentTypeTableSpecified = true;
                _contentTypeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ContentTypeTableSpecified { get; set; }

    }
}

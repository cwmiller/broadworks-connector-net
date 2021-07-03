using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFileRepositoryDeviceGetListRequest.
    /// Contains a table with column headings : "Name","Protocol", "Root Directory", "Extended File Capture Support" in a row for each file repository.
    /// <see cref="SystemFileRepositoryDeviceGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10304""}]")]
    public class SystemFileRepositoryDeviceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryTable;

        [XmlElement(ElementName = "fileRepositoryTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10304")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryTable
        {
            get => _fileRepositoryTable;
            set
            {
                FileRepositoryTableSpecified = true;
                _fileRepositoryTable = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryTableSpecified { get; set; }

    }
}

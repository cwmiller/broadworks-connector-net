using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFileRepositoryDeviceUserGetListRequest.
    /// Contains a table with column headings : "User Name","Allow Get","Allow Delete","Allow Put" in a row for each file repository user.
    /// <see cref="SystemFileRepositoryDeviceUserGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10434""}]")]
    public class SystemFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

        [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10434")]
        public BroadWorksConnector.Ocip.Models.C.OCITable FileRepositoryUserTable
        {
            get => _fileRepositoryUserTable;
            set
            {
                FileRepositoryUserTableSpecified = true;
                _fileRepositoryUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryUserTableSpecified { get; set; }

    }
}

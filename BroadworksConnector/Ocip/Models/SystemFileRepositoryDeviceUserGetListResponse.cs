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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10552""}]")]
    public class SystemFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

        [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10552")]
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

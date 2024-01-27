using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderFileRepositoryDeviceUserGetListRequest.
    /// Contains a table with column headings : "User Name","Allow Delete","Allow Get","Allow Put" in a row for each file repository service provider user.
    /// <see cref="ServiceProviderFileRepositoryDeviceUserGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4387""}]")]
    public class ServiceProviderFileRepositoryDeviceUserGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _fileRepositoryUserTable;

        [XmlElement(ElementName = "fileRepositoryUserTable", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4387")]
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

using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a department of an enterprise.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""405ec18fe08719ecf74e749d7e18c88f:401""}]")]
    public class EnterpriseDepartmentModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _enterpriseId;

        [XmlElement(ElementName = "enterpriseId", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:401")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseId
        {
            get => _enterpriseId;
            set
            {
                EnterpriseIdSpecified = true;
                _enterpriseId = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseIdSpecified { get; set; }

        protected string _departmentName;

        [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:401")]
        [MinLength(1)]
        [MaxLength(50)]
        public string DepartmentName
        {
            get => _departmentName;
            set
            {
                DepartmentNameSpecified = true;
                _departmentName = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentNameSpecified { get; set; }

        protected string _newDepartmentName;

        [XmlElement(ElementName = "newDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:401")]
        [MinLength(1)]
        [MaxLength(50)]
        public string NewDepartmentName
        {
            get => _newDepartmentName;
            set
            {
                NewDepartmentNameSpecified = true;
                _newDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool NewDepartmentNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey _newParentDepartmentKey;

        [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"405ec18fe08719ecf74e749d7e18c88f:401")]
        public BroadWorksConnector.Ocip.Models.EnterpriseDepartmentKey NewParentDepartmentKey
        {
            get => _newParentDepartmentKey;
            set
            {
                NewParentDepartmentKeySpecified = true;
                _newParentDepartmentKey = value;
            }
        }

        [XmlIgnore]
        protected bool NewParentDepartmentKeySpecified { get; set; }

    }
}

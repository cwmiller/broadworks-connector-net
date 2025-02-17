using BroadWorksConnector.Ocip;
using BroadWorksConnector.Ocip.Models;
using BroadWorksConnector.Ocip.Models.C;
using Org.XmlUnit.Builder;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace BroadWorksConnector.Tests
{
    /// <summary>
    /// Tests Serializer class
    /// </summary>
    public class SerializerTests
    {
        private readonly Serializer _serializer;

        public SerializerTests()
        {
            _serializer = new Serializer("BroadWorksConnector.Ocip.Models");
        }

        [Fact]
        public void SerializeGroupOutgoingCallingPlanRedirectingModifyListRequest()
        {
            var departmentKey = new GroupDepartmentKey()
            {
                ServiceProviderId = "Service Provider ID",
                GroupId = "Group ID",
                Name = "Department Name"
            };

            var permissions = new OutgoingCallingPlanRedirectingPermissionsModify()
            {
                Group = true,
                Local = true,
                TollFree = true,
                Toll = true,
                International = false,
                OperatorAssisted = false,
                ChargeableDirectoryAssisted = false,
                SpecialServicesI = false,
                SpecialServicesII = false,
                PremiumServicesI = false,
                PremiumServicesII = false,
                Casual = false,
                UrlDialing = false,
                Unknown = false
            };

            var departmentPermission = new OutgoingCallingPlanRedirectingDepartmentPermissionsModify()
            {
                DepartmentKey = departmentKey,
                Permissions = permissions
            };

            var request = new GroupOutgoingCallingPlanRedirectingModifyListRequest()
            {
                ServiceProviderId = "Service Provider ID",
                GroupId = "Group ID",
                DepartmentPermissions =
                [
                    departmentPermission
                ]
            };

            var document = new BroadsoftDocument<GroupOutgoingCallingPlanRedirectingModifyListRequest>()
            {
                SessionId = "636956952081463406",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/GroupOutgoingCallingPlanRedirectingModifyListRequest.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void SerializeWithEnums()
        {
            var request = new UserGetListInGroupRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "Group",
                SearchCriteriaUserFirstName =
                [
                    new SearchCriteriaUserFirstName()
                    {
                        IsCaseInsensitive = false,
                        Mode = SearchMode.EqualTo,
                        Value = "John"
                    }
                ]
            };

            var document = new BroadsoftDocument<UserGetListInGroupRequest>()
            {
                SessionId = "acbdf1234567890",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/UserGetListInGroupRequest.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void SerializeWithListOfEnums()
        {
            var request = new UserServiceAssignListRequest()
            {
                UserId = "john.doe@test.com",
                ServiceName =
                [
                    UserService.AdviceOfCharge,
                    UserService.AlternateNumbers,
                    UserService.AnonymousCallRejection,
                    UserService.AttendantConsole
                ]
            };

            var document = new BroadsoftDocument<UserServiceAssignListRequest>()
            {
                SessionId = "acbdf1234567890",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/UserServiceAssignListRequest.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void SerializeWithInheritedProperties()
        {
            var request = new GroupUserCallForwardingSettingsGetListRequest()
            {
                ServiceProviderId = "SP",
                GroupId = "GRP",
                CallForwardingService = CallForwardingService.CallForwardingAlways,
                ResponsePagingControl = new ResponsePagingControl
                {
                    ResponsePageSize = 10,
                    ResponseStartIndex = 1
                },
                SortByExtension = new SortByExtension
                {
                    IsAscending = false,
                    IsCaseSensitive = false
                }
            };

            var document = new BroadsoftDocument<GroupUserCallForwardingSettingsGetListRequest>()
            {
                SessionId = "acbdf1234567890",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/GroupUserCallForwardingSettingsGetListRequest.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void DeserializeUserGetListInGroupRequest()
        {
            var xmlData = File.ReadAllBytes(@"test-data/UserGetListInGroupResponse.xml");
            var xml = Encoding.UTF8.GetString(xmlData);

            var document = _serializer.Deserialize<UserGetListInGroupResponse>(xml);

            Assert.IsType<UserGetListInGroupResponse>(document.Command.First());

            var response = document.Command.First() as UserGetListInGroupResponse;

            Assert.IsType<OCITable>(response.UserTable);

            Assert.Equal(2, response.UserTable.Row.Count);
            Assert.Equal("john.doe@test.com", response.UserTable.Row[0].Col[0]);
            Assert.Equal("Doe", response.UserTable.Row[0].Col[1]);
            Assert.Equal("John", response.UserTable.Row[0].Col[2]);
            Assert.Equal("", response.UserTable.Row[0].Col[3]);
            Assert.Equal("", response.UserTable.Row[0].Col[4]);
            Assert.Equal("", response.UserTable.Row[0].Col[5]);
            Assert.Equal("", response.UserTable.Row[0].Col[6]);
            Assert.Equal("Doe", response.UserTable.Row[0].Col[7]);
            Assert.Equal("John", response.UserTable.Row[0].Col[8]);
            Assert.Equal("false", response.UserTable.Row[0].Col[9]);
            Assert.Equal("100", response.UserTable.Row[0].Col[10]);
            Assert.Equal("", response.UserTable.Row[0].Col[11]);
            Assert.Equal("", response.UserTable.Row[0].Col[12]);

            Assert.Equal("jane.doe@test.com", response.UserTable.Row[1].Col[0]);
            Assert.Equal("Doe", response.UserTable.Row[1].Col[1]);
            Assert.Equal("Jane", response.UserTable.Row[1].Col[2]);
            Assert.Equal("", response.UserTable.Row[1].Col[3]);
            Assert.Equal("", response.UserTable.Row[1].Col[4]);
            Assert.Equal("", response.UserTable.Row[1].Col[5]);
            Assert.Equal("", response.UserTable.Row[1].Col[6]);
            Assert.Equal("Doe", response.UserTable.Row[1].Col[7]);
            Assert.Equal("Jane", response.UserTable.Row[1].Col[8]);
            Assert.Equal("false", response.UserTable.Row[1].Col[9]);
            Assert.Equal("101", response.UserTable.Row[1].Col[10]);
            Assert.Equal("", response.UserTable.Row[1].Col[11]);
            Assert.Equal("", response.UserTable.Row[1].Col[12]);
        }

        [Fact]
        public void DeserializeLoginResponse14sp4()
        {
            var xmlData = File.ReadAllBytes(@"test-data/LoginResponse14sp4.xml");
            var xml = Encoding.UTF8.GetString(xmlData);

            var document = _serializer.Deserialize<LoginResponse14sp4>(xml);

            Assert.IsType<LoginResponse14sp4>(document.Command.First());

            var response = document.Command.First() as LoginResponse14sp4;

            Assert.Equal(LoginType.ServiceProvider, response.LoginType);
            Assert.Equal("en_US", response.Locale);
            Assert.Equal("ISO-8859-1", response.Encoding);
            Assert.Null(response.GroupId);
            Assert.Equal("SP123", response.ServiceProviderId);
            Assert.False(response.IsEnterprise);
            Assert.Equal(2147483647, response.PasswordExpiresDays);
            Assert.Equal("test.com", response.UserDomain);
        }

        [Fact]
        public void TestNillableProperty()
        {
            var request = new UserModifyRequest22()
            {
                UserId = "test@test.com",
                Extension = "999",
                PhoneNumber = null
            };

            var document = new BroadsoftDocument<UserModifyRequest22>()
            {
                SessionId = "636956952081463406",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/UserModifyRequest22.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void TestNillableAbstractProperty()
        {
            var request = new UserModifyRequest22()
            {
                UserId = "test@test.com",
                Extension = "999",
                PhoneNumber = null,
                Department = null
            };

            var document = new BroadsoftDocument<UserModifyRequest22>()
            {
                SessionId = "636956952081463406",
                Protocol = "OCI",
                Command = [request]
            };

            var xml = _serializer.Serialize(document);

            var diff =
                DiffBuilder.Compare(Input.FromFile(@"test-data/UserModifyRequest22-nulldepartment.xml"))
                .WithTest(xml).Build();

            Assert.False(diff.HasDifferences());
        }

        [Fact]
        public void TestErrorResponse()
        {
            var xmlData = File.ReadAllBytes(@"test-data/ErrorResponse.xml");
            var xml = Encoding.UTF8.GetString(xmlData);

            var document = _serializer.Deserialize<ErrorResponse>(xml);

            Assert.IsType<ErrorResponse>(document.Command.First());
        }

        [Fact]
        public void TestSuccessResponse()
        {
            var xmlData = File.ReadAllBytes(@"test-data/SuccessResponse.xml");
            var xml = Encoding.UTF8.GetString(xmlData);

            var document = _serializer.Deserialize<SuccessResponse>(xml);

            Assert.IsType<SuccessResponse>(document.Command.First());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            int oldGroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);

            int newGroups = app.Groups.GetGroupList();            

            Assert.AreEqual(oldGroups+1, newGroups);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;
using System.Text.RegularExpressions;

namespace addressbook_tests_autoit
{
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove();


            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}

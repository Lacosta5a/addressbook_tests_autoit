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
            app.Groups.CheckIf2GroupsExist();

            int oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove();


            int newGroups = app.Groups.GetGroupList();            

            Assert.AreEqual(oldGroups-1, newGroups);
        }       
    }
}

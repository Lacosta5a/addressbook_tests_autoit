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

            int oldGroups = app.Groups.GetGroupList();

            if (oldGroups == 1)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "123"
                };
                app.Groups.Add(newGroup);
            }

            app.Groups.Remove();


            int newGroups = app.Groups.GetGroupList();

            Assert.AreEqual(oldGroups-1, newGroups);
        }       
    }
}

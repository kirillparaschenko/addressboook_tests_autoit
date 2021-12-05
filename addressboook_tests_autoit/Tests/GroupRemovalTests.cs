using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressboook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> checkGroups = app.Groups.GetGroupList();
            if (checkGroups.Count == 1)
            {
                app.Groups.Add(new GroupData()
                {
                    Name = "NewTestGroup"
                });
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
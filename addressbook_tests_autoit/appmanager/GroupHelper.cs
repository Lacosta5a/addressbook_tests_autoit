﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    public class GroupHelper:HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
        public static string DELETEGROUP = "Delete group";
        public GroupHelper(ApplicationManager manager):base(manager) { }

        public void Add(GroupData newGroup)
        {
            OpenGroupDialogue();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            CloseGroupsDialogue();
        }


        public int GetGroupList()
        {

            OpenGroupDialogue();
            string count = aux.ControlTreeView(
                GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "GetItemCount", "#0", "");

            CloseGroupsDialogue();
            int.Parse(count);
            return int.Parse(count);
        }



        public void CloseGroupsDialogue()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        private void OpenGroupDialogue()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }


        public void Remove()
        {
            OpenGroupDialogue();
            aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                "Select", "#0|#0", "");
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            ConfirmRemoval();
            CloseGroupsDialogue();
        }

        private void ConfirmRemoval()
        {
            aux.WinWait(DELETEGROUP);
            aux.ControlClick(DELETEGROUP, "", "WindowsForms10.BUTTON.app.0.2c908d51");
            aux.ControlClick(DELETEGROUP, "", "WindowsForms10.BUTTON.app.0.2c908d53");
        }

        public void CheckIf2GroupsExist()
        {
            if (GetGroupList() == 1)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "222"
                };
                Add(newGroup);
            }
        }
    }
}
using ToDOList;


Dictionary<int, IMenu> menus= new Dictionary<int, IMenu>();
menus.Add(1, new MenuNewTask());
menus.Add(2, new MenuTaskCompleted());
menus.Add(3, new MenuExcludeTask());

MenuIndex menuIndex = new MenuIndex();

while (true)
{
    Console.Clear();
    menuIndex.ShowHeader();
    int cmd = menuIndex.ShowOptions();
    if (cmd == 4) return;
    Console.Clear();
    menus[cmd].ShowHeader();
    menus[cmd].ShowOptions();
}
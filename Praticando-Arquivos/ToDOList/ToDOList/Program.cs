using ToDOList;


Dictionary<int, IMenu> menus= new Dictionary<int, IMenu>();
menus.Add(1, new MenuNewTask());
menus.Add(2, new MenuTaskCompleted());

MenuIndex menuIndex = new MenuIndex();

while (true)
{
    Console.Clear();
    menuIndex.ShowHeader();
    int cmd = menuIndex.ShowOptions();
    if (cmd == 3) return;
    Console.Clear();
    menus[cmd].ShowHeader();
    menus[cmd].ShowOptions();
}
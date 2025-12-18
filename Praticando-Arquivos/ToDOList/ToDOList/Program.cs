using ToDOList;


Dictionary<int, IMenu> menus= new Dictionary<int, IMenu>();
menus.Add(1, new MenuNewTask());

MenuIndex menuIndex = new MenuIndex();

while (true)
{
    Console.Clear();
    menuIndex.ShowHeader();
    int cmd = menuIndex.ShowOptions();
    Console.Clear();
    menus[cmd].ShowHeader();
    menus[cmd].ShowOptions();
}
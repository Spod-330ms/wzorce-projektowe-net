using EX10Composite;

MenuCategoryComposite menu = new MenuCategoryComposite("Main Menu");
MenuCategoryComposite appetizers = new MenuCategoryComposite("Appetizers");
MenuCategoryComposite mainCourses = new MenuCategoryComposite("Main Courses");
MenuCategoryComposite meatCourses = new MenuCategoryComposite("Meat Courses");
MenuCategoryComposite fishCourses = new MenuCategoryComposite("Fish Courses");
Dish dish1 = new Dish("Spring Rolls", 5.99);
Dish dish2 = new Dish("Grilled Chicken", 12.99);
Dish dish3 = new Dish("Pasta Alfredo", 10.99);
Dish dish4 = new Dish("Fish Tacos", 11.99);
Dish dish5 = new Dish("Caesar Salad", 7.99);
Dish dish6 = new Dish("Salmon Fillet", 15.99);

appetizers.AddMenuItem(dish1);

meatCourses.AddMenuItem(dish2);
meatCourses.AddMenuItem(dish3);
meatCourses.AddMenuItem(dish5);

fishCourses.AddMenuItem(dish4);
fishCourses.AddMenuItem(dish6);

mainCourses.AddMenuItem(meatCourses);
mainCourses.AddMenuItem(fishCourses);

menu.AddMenuItem(appetizers);
menu.AddMenuItem(mainCourses);

menu.DisplayName();
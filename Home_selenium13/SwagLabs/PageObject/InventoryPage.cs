using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_selenium13.SwagLabs.PageObject
{
    /*
    *Задачка по локаторам используется чтобы потом было проще писать тесты, можно  пропускать и использовать как полезные материалы *

Создать новый класс, в нем для ресурса https://www.saucedemo.com/  составить список локаторов, можно искать на ВСЕХ страницах приложения (driver.findWebElement(<локатор>)) для КАЖДОГО из примеров локаторов ниже:

id    name  classname
tagname  linktext  partiallinktext
xpath
Поиск по атрибуту, например By.xpath("//tag[@attribute='value']");
Поиск по тексту, например By.xpath("//tag[text()='text']");
Поиск по частичному совпадению атрибута, например By.xpath("//tag[contains(@attribute,'text')]");
Поиск по частичному совпадению текста, например By.xpath("//tag[contains(text(),'text')]");
ancestor, например //*[text()='Enterprise Testing']//ancestor::div
descendant
following
parent
preceding
Подсказка:  https://www.w3schools.com/xml/xpath_axes.asp
*поиск элемента с условием AND, например //input[@class='_2zrpKA _1dBPDZ' and @type='text']
css
.class
.class1.class2
.class1 .class2
#id
tagname
tagname.class
 [attribute=value] [attribute~=value] [attribute|=value] [attribute^=value] [attribute$=value][attribute*=value]
     */

    internal class InventoryPage
    {
    }
}

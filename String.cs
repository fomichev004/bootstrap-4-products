
#//public string Name;
#
#//string input
#
#//string output = Name.ToTitleCase;
#
#//Trim // Trim убрать лишние пробелы в строке 
#// https://www.youtube.com/watch?v=vNJP7PIx4DM&list=PL05SB3rBbUsraqiEUeS70RKhVAu97nGeb&index=22
#// 20:00. 28:00

#//python
NameDriver_str = input('Введите ФИО')

print ( '{}'.format( NameDriver_str ).title().strip() )

Car_str = input('Введите номер авто')
print ( '{}'.format( Car_str ).upper().replace(" ", " / ").replace("-", "/").replace("  ", " ").strip() )

Number_int = input('Телефон')
print ( '{}'.format( Number_int ).strip() )

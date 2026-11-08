cmake_minimum_required(VERSION 3.8)
project(MyLibrary NONE) # ќтключаем стандартный поиск C++/C# компил€торов, чтобы убрать ошибку

# ”казываем выходной бинарник библиотеки
set(TARGET_DLL "bin/Release/net8.0/MyLibrary.dll")

# —оздаем кастомную цель дл€ компил€ции через dotnet CLI
add_custom_target(MyLibrary ALL
    COMMAND dotnet build -c Release
    WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}
    COMMENT "—борка библиотеки MyLibrary через .NET Core SDK..."
)
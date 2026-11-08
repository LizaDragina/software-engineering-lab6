cmake_minimum_required(VERSION 3.8)
project(MainApp NONE)

set(EXT_LIB_DIR "${CMAKE_CURRENT_SOURCE_DIR}/../target/lib")
set(LIB_PATH "${EXT_LIB_DIR}/MyLibrary.dll")

# Путь для установки man-страницы по стандартам Unix
set(MAN_INSTALL_DIR "${CMAKE_CURRENT_SOURCE_DIR}/../target/share/man/man1")

function(check_library_exists path)
    if(NOT EXISTS "${path}")
        message(FATAL_ERROR "\n[ОШИБКА CMAKE]: Зависимая библиотека не найдена: ${path}")
    endif()
endfunction()

check_library_exists("${LIB_PATH}")

# Сборка приложения и автоматическая "установка" man-страницы
add_custom_target(MainApp ALL
    COMMAND dotnet build -c Release /p:ReferencePath=${EXT_LIB_DIR}
    # Команды CMake для создания структуры папок и копирования файла справки
    COMMAND ${CMAKE_COMMAND} -E make_directory ${MAN_INSTALL_DIR}
    COMMAND ${CMAKE_COMMAND} -E copy ${CMAKE_CURRENT_SOURCE_DIR}/mainapp.1 ${MAN_INSTALL_DIR}/mainapp.1
    WORKING_DIRECTORY ${CMAKE_CURRENT_SOURCE_DIR}
    COMMENT "Сборка приложения MainApp и установка man-страницы..."
)
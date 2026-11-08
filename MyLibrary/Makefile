PREFIX = ../target
LIB_DIR = $(PREFIX)/lib
INC_DIR = $(PREFIX)/include
TARGET_DLL = bin/Release/net8.0/MyLibrary.dll

.PHONY: compile install clean uninstall
compile:
	dotnet build -c Release
install: compile
	mkdir -p $(LIB_DIR)
	mkdir -p $(INC_DIR)
	cp $(TARGET_DLL) $(LIB_DIR)/
	cp $(TARGET_DLL) $(INC_DIR)/
clean:
	rm -rf bin/ obj/
uninstall:
	rm -f $(LIB_DIR)/MyLibrary.dll
	rm -f $(INC_DIR)/MyLibrary.dll
# Сценарий сборки основного консольного приложения
PREFIX = ../target
BIN_DIR = $(PREFIX)/bin
EXT_LIB_DIR = ../target/lib
TARGET_FILES = bin/Release/net8.0/*

.PHONY: compile install clean uninstall
compile:
	dotnet build -c Release /p:ReferencePath=$(EXT_LIB_DIR)
install: compile
	mkdir -p $(BIN_DIR)
	cp -r $(TARGET_FILES) $(BIN_DIR)/
clean:
	rm -rf bin/ obj/
uninstall:
	rm -rf $(BIN_DIR)
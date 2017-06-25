@echo off
@color 06

set GoDevWork=%cd%\

echo "Build For Win..."

set GOOS=windows
set GOARCH=amd64
set GOPATH=%GoDevWork%;%GOPATH%
go build -ldflags "-s -w" -o ip_locater.exe

echo "--------- Build For Win Success!"

echo "Build For Linux..."
set GOOS=linux
set GOARCH=amd64
set GOPATH=%GoDevWork%;%GOPATH%
go build -ldflags "-s -w" -o ip_locater

echo "--------- Build For Linux Success!"

pause
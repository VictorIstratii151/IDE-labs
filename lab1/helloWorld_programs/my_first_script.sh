export PATH="$PATH:~/scripts"

clear

echo "Hi, $USER!"
echo
echo "Executing a python script:"
python hello.py
echo
echo "Executing a ruby script:"
ruby hello.rb
echo
echo "Compiling and executing a java program:"
javac hello.java
java HelloWorld
echo
echo "Compiling and executing a C program:"
gcc hello.c -o hello
./hello
echo
echo "Compiling and executing a C++ program:"
g++ hello.cpp -o hello
./hello


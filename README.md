# prjInventoryManagement

# What is a Pointer Type?
## Pointer types in C# are variables that store memory addresses of another type or variable. A pointer can refer to an object of any one data type, it cannot refer to a bit field or a reference.  For example, an integer variable holds an integer value, however an integer pointer holds the address of a integer variable.

# When are Pointer Types used?
## Pointers are frequently used when interacting with unmanaged code, this allows C# code to pass data directly to and from these unmanaged functions which often expect memory addresses. Pointer types in C# are used in specific scenarios where direct memory manipulation is required, typically in conjunction with "unsafe" code blocks.

# Why do Pointer Types require Unsafe Context?
## Pointers allow direct memory access and manipulation, which can interfere with the garbage collector's ability to track and manage object lifetimes. If an object's memory is directly handled by pointers, the garbage collector might not correctly identify when it's safe to deallocate, leading to memory leaks or corruption. Pointers can be cast between different types, potentially leading to operations on data that is not of the expected type. This can introduce type-related errors that the CLR's type-safe environment typically prevents.

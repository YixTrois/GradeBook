// Ecapsulate the code in a better abstraction.
// we want to build a new class taht will encapsulate what we are going to
// write or need inside of the main method here.  we will end up with the code we essentailly have right now. 
// it is just going to be reorganized and repositioned to be easier to work with

// any type of class and type we write should be under the namespace. 
// it's not safe to get rid of the name space and put the class under the global namespace.
// just by having a namespace that doesn't start with the name system
// we are able to avoid the conflicts with any of the built-in .NET types.

// we can have dot in the namespace. 
// like namespace GradeBook.Math

// prefer not to have namespace in the code part.
// field: a variable declaration. but you cannot use var to define it anymore. basically is defining things in the class
// we need to initialize a value.

// for a constructor, it must have the same name as the class, and it can not have a return 
// the reason we create a class is that we want to hide the complexity within the class. 

// protection level: 

// this.name is always available in a constructor. you use it when you want to refer to the object that is currently being operated on.
// this is implicitly used when i want to access to a member of the class. 

// static:
// the opposite of static is public
// if we make the grades field also static, it means that grades would no longer be contained and
// encapsulated by an object of type Book. instead this list of grades would be associated with the class Book.

// normally you don't want to use the static method unless you really have to, 
// because it negates the purpose of object oreiented programming

// it is better to have all the public method together above, and all the private method downbelow
// if it is internal, then it means it can only be accessed inside the same project file
// public means anyone who references this project has the ability to consume and use the particular type.


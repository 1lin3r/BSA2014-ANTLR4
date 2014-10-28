Stuff for 4th lesson of ANTLR in Binary Studio Academy

Contains example for Java target language only

Simple calculator with memory that calculates expressions with no listeners or visitors (using embedded actions only)

How to run:
1) Generate parser
```shell
> java -jar antlr-4.4-complete.jar Expr.g4 -no-listener
```

2) Compile application
```shell
> javac -cp .;antlr-4.4-complete.jar *.java
```

3) Run application
```shell
> java -cp .;antlr-4.4-complete.jar Calc
```

4) Start entering expressions such as:
2+3
a=5
a*100

5) Press Ctrl+Z to exit




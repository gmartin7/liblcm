// ParserGenerator by Malcolm Crowe August 1995, 2000, 2003
// 2003 version (4.1+ of Tools) implements F. DeRemer & T. Pennello:
// Efficient Computation of LALR(1) Look-Ahead Sets
// ACM Transactions on Programming Languages and Systems
// Vol 4 (1982) p. 615-649
// See class SymbolsGen in parser.cs

using System;using Tools;
namespace YYClass {
//%BASE
public class BASE : TOKEN{ public override string yyname() { return "BASE";}
 public BASE(Lexer yyl):base(yyl) {}}
//%THIS
public class THIS : TOKEN{ public override string yyname() { return "THIS";}
 public THIS(Lexer yyl):base(yyl) {}}
//%NEW
public class NEW : TOKEN{ public override string yyname() { return "NEW";}
 public NEW(Lexer yyl):base(yyl) {}}
//%ID
public class ID : TOKEN{ public override string yyname() { return "ID";}
 public ID(Lexer yyl):base(yyl) {}}
//%ANY
public class ANY : TOKEN{ public override string yyname() { return "ANY";}
 public ANY(Lexer yyl):base(yyl) {}}
//%COLON
public class COLON : TOKEN{ public override string yyname() { return "COLON";}
 public COLON(Lexer yyl):base(yyl) {}}
//%SEMICOLON
public class SEMICOLON : TOKEN{ public override string yyname() { return "SEMICOLON";}
 public SEMICOLON(Lexer yyl):base(yyl) {}}
//%LBRACE
public class LBRACE : TOKEN{ public override string yyname() { return "LBRACE";}
 public LBRACE(Lexer yyl):base(yyl) {}}
//%RBRACE
public class RBRACE : TOKEN{ public override string yyname() { return "RBRACE";}
 public RBRACE(Lexer yyl):base(yyl) {}}
//%LPAREN
public class LPAREN : TOKEN{ public override string yyname() { return "LPAREN";}
 public LPAREN(Lexer yyl):base(yyl) {}}
//%RPAREN
public class RPAREN : TOKEN{ public override string yyname() { return "RPAREN";}
 public RPAREN(Lexer yyl):base(yyl) {}}
//%LBRACK
public class LBRACK : TOKEN{ public override string yyname() { return "LBRACK";}
 public LBRACK(Lexer yyl):base(yyl) {}}
//%RBRACK
public class RBRACK : TOKEN{ public override string yyname() { return "RBRACK";}
 public RBRACK(Lexer yyl):base(yyl) {}}
//%|cs0tokens
public class yycs0tokens : Tokens {
 public yycs0tokens(ErrorHandler eh):base(eh) { arr = new int[] {
6,101,4,16,117,
0,115,0,45,0,
97,0,115,0,99,
0,105,0,105,0,
2,0,102,5,27,
7,27,103,9,1,
27,3,94,0,104,
5,1,3,94,0,
2,1,7,26,105,
9,1,26,3,36,
0,106,5,1,3,
36,0,2,1,7,
25,107,9,1,25,
3,43,0,108,5,
1,3,43,0,2,
1,7,24,109,9,
1,24,3,33,0,
110,5,5,3,34,
0,2,1,3,58,
0,2,1,3,59,
0,2,1,3,39,
0,2,1,3,33,
0,2,1,7,23,
111,9,1,23,3,
187,0,112,5,1,
3,187,0,2,1,
7,22,113,9,1,
22,3,171,0,114,
5,1,3,171,0,
2,1,7,21,115,
9,1,21,3,59,
15,116,5,4,3,
125,0,2,1,3,
93,0,2,1,3,
41,0,2,1,3,
59,15,2,1,7,
20,117,9,1,20,
3,58,15,118,5,
4,3,123,0,2,
1,3,91,0,2,
1,3,58,15,2,
1,3,40,0,2,
1,7,19,119,9,
1,19,3,45,0,
120,5,1,3,45,
0,2,1,7,18,
121,9,1,18,3,
63,32,122,5,2,
3,63,32,2,1,
3,95,0,2,1,
7,17,123,9,1,
17,3,0,224,124,
5,1,3,0,224,
2,1,7,15,125,
9,1,15,3,15,
7,126,5,1,3,
15,7,2,1,7,
14,127,9,1,14,
3,1,0,128,5,
5,3,1,0,2,
1,3,13,0,2,
1,3,9,0,2,
1,3,10,0,2,
1,3,0,0,2,
1,7,13,129,9,
1,13,3,41,32,
130,5,1,3,41,
32,2,1,7,12,
131,9,1,12,3,
40,32,132,5,1,
3,40,32,2,1,
7,11,133,9,1,
11,3,160,0,134,
5,2,3,160,0,
2,1,3,32,0,
2,1,7,10,135,
9,1,10,3,178,
0,136,5,1,3,
178,0,2,1,7,
9,137,9,1,9,
3,96,33,138,5,
1,3,96,33,2,
1,7,8,139,9,
1,8,3,96,6,
140,5,11,3,55,
0,2,1,3,48,
0,2,1,3,57,
0,2,1,3,50,
0,2,1,3,52,
0,2,1,3,96,
6,2,1,3,54,
0,2,1,3,56,
0,2,1,3,49,
0,2,1,3,51,
0,2,1,3,53,
0,2,1,7,7,
141,9,1,7,3,
136,4,142,5,1,
3,136,4,2,1,
7,6,143,9,1,
6,3,3,9,144,
5,1,3,3,9,
2,1,7,5,145,
9,1,5,3,0,
3,146,5,1,3,
0,3,2,1,7,
4,147,9,1,4,
3,187,1,148,5,
1,3,187,1,2,
1,7,3,149,9,
1,3,3,176,2,
150,5,1,3,176,
2,2,1,7,2,
151,9,1,2,3,
197,1,152,5,1,
3,197,1,2,1,
7,1,153,9,1,
1,3,170,0,154,
5,27,3,121,0,
2,1,3,116,0,
2,1,3,111,0,
2,1,3,106,0,
2,1,3,101,0,
2,1,3,170,0,
2,1,3,118,0,
2,1,3,113,0,
2,1,3,108,0,
2,1,3,103,0,
2,1,3,98,0,
2,1,3,120,0,
2,1,3,115,0,
2,1,3,110,0,
2,1,3,105,0,
2,1,3,100,0,
2,1,3,122,0,
2,1,3,117,0,
2,1,3,112,0,
2,1,3,107,0,
2,1,3,102,0,
2,1,3,97,0,
2,1,3,119,0,
2,1,3,114,0,
2,1,3,109,0,
2,1,3,104,0,
2,1,3,99,0,
2,1,7,0,155,
9,1,0,3,192,
0,156,5,27,3,
89,0,2,1,3,
84,0,2,1,3,
79,0,2,1,3,
74,0,2,1,3,
69,0,2,1,3,
86,0,2,1,3,
81,0,2,1,3,
76,0,2,1,3,
71,0,2,1,3,
66,0,2,1,3,
192,0,2,1,3,
88,0,2,1,3,
83,0,2,1,3,
78,0,2,1,3,
73,0,2,1,3,
68,0,2,1,3,
90,0,2,1,3,
85,0,2,1,3,
80,0,2,1,3,
75,0,2,1,3,
70,0,2,1,3,
65,0,2,1,3,
87,0,2,1,3,
82,0,2,1,3,
77,0,2,1,3,
72,0,2,1,3,
67,0,2,1,7,
27,2,0,157,5,
1,158,4,18,89,
0,89,0,73,0,
78,0,73,0,84,
0,73,0,65,0,
76,0,159,12,1,
259,160,5,104,3,
89,0,161,12,1,
1855,162,5,63,3,
109,0,163,12,1,
1876,164,5,63,3,
109,0,163,3,111,
0,163,3,113,0,
163,3,115,0,163,
3,117,0,163,3,
119,0,163,3,121,
0,163,3,48,0,
163,3,50,0,163,
3,52,0,163,3,
54,0,163,3,56,
0,163,3,66,0,
163,3,68,0,163,
3,70,0,163,3,
72,0,163,3,74,
0,163,3,76,0,
163,3,78,0,163,
3,80,0,163,3,
82,0,163,3,84,
0,163,3,86,0,
163,3,88,0,163,
3,90,0,163,3,
98,0,163,3,100,
0,163,3,102,0,
163,3,104,0,163,
3,106,0,163,3,
108,0,163,3,110,
0,163,3,112,0,
163,3,114,0,163,
3,116,0,163,3,
118,0,163,3,120,
0,163,3,122,0,
163,3,49,0,163,
3,51,0,163,3,
53,0,163,3,55,
0,163,3,57,0,
163,3,65,0,163,
3,67,0,163,3,
69,0,163,3,71,
0,163,3,73,0,
163,3,75,0,163,
3,77,0,163,3,
79,0,163,3,81,
0,163,3,83,0,
163,3,85,0,163,
3,87,0,163,3,
89,0,163,3,95,
0,163,3,97,0,
163,3,99,0,163,
3,101,0,163,3,
103,0,163,3,105,
0,163,3,107,0,
163,165,11,1,164,
0,166,4,4,73,
0,68,0,3,111,
0,163,3,113,0,
163,3,115,0,163,
3,117,0,163,3,
119,0,163,3,121,
0,163,3,48,0,
163,3,50,0,163,
3,52,0,163,3,
54,0,163,3,56,
0,163,3,66,0,
163,3,68,0,163,
3,70,0,163,3,
72,0,163,3,74,
0,163,3,76,0,
163,3,78,0,163,
3,80,0,163,3,
82,0,163,3,84,
0,163,3,86,0,
163,3,88,0,163,
3,90,0,163,3,
98,0,163,3,100,
0,163,3,102,0,
163,3,104,0,163,
3,106,0,163,3,
108,0,163,3,110,
0,163,3,112,0,
163,3,114,0,163,
3,116,0,163,3,
118,0,163,3,120,
0,163,3,122,0,
163,3,49,0,163,
3,51,0,163,3,
53,0,163,3,55,
0,163,3,57,0,
163,3,65,0,163,
3,67,0,163,3,
69,0,163,3,71,
0,163,3,73,0,
163,3,75,0,163,
3,77,0,163,3,
79,0,163,3,81,
0,163,3,83,0,
163,3,85,0,163,
3,87,0,163,3,
89,0,163,3,95,
0,163,3,97,0,
163,3,99,0,163,
3,101,0,163,3,
103,0,163,3,105,
0,163,3,107,0,
163,167,11,1,164,
0,166,3,178,0,
168,12,1,260,169,
5,0,170,11,1,
256,0,171,4,6,
65,0,78,0,89,
0,3,103,0,161,
3,192,0,168,3,
117,0,161,3,56,
0,168,3,70,0,
161,3,84,0,161,
3,9,0,172,12,
1,2069,173,5,0,
174,11,1,2,175,
11,1,256,0,171,
3,98,0,176,12,
1,3681,177,5,63,
3,109,0,163,3,
111,0,163,3,113,
0,163,3,115,0,
163,3,117,0,163,
3,119,0,163,3,
121,0,163,3,48,
0,163,3,50,0,
163,3,52,0,163,
3,54,0,163,3,
56,0,163,3,66,
0,163,3,68,0,
163,3,70,0,163,
3,72,0,163,3,
74,0,163,3,76,
0,163,3,78,0,
163,3,80,0,163,
3,82,0,163,3,
84,0,163,3,86,
0,163,3,88,0,
163,3,90,0,163,
3,98,0,163,3,
100,0,163,3,102,
0,163,3,104,0,
163,3,106,0,163,
3,108,0,163,3,
110,0,163,3,112,
0,163,3,114,0,
163,3,116,0,163,
3,118,0,163,3,
120,0,163,3,122,
0,163,3,49,0,
163,3,51,0,163,
3,53,0,163,3,
55,0,163,3,57,
0,163,3,65,0,
163,3,67,0,163,
3,69,0,163,3,
71,0,163,3,73,
0,163,3,75,0,
163,3,77,0,163,
3,79,0,163,3,
81,0,163,3,83,
0,163,3,85,0,
163,3,87,0,163,
3,89,0,163,3,
95,0,163,3,97,
0,178,12,1,3754,
179,5,63,3,109,
0,163,3,111,0,
163,3,113,0,163,
3,115,0,180,12,
1,3818,181,5,63,
3,109,0,163,3,
111,0,163,3,113,
0,163,3,115,0,
163,3,117,0,163,
3,119,0,163,3,
121,0,163,3,48,
0,163,3,50,0,
163,3,52,0,163,
3,54,0,163,3,
56,0,163,3,66,
0,163,3,68,0,
163,3,70,0,163,
3,72,0,163,3,
74,0,163,3,76,
0,163,3,78,0,
163,3,80,0,163,
3,82,0,163,3,
84,0,163,3,86,
0,163,3,88,0,
163,3,90,0,163,
3,98,0,163,3,
100,0,163,3,102,
0,163,3,104,0,
163,3,106,0,163,
3,108,0,163,3,
110,0,163,3,112,
0,163,3,114,0,
163,3,116,0,163,
3,118,0,163,3,
120,0,163,3,122,
0,163,3,49,0,
163,3,51,0,163,
3,53,0,163,3,
55,0,163,3,57,
0,163,3,65,0,
163,3,67,0,163,
3,69,0,163,3,
71,0,163,3,73,
0,163,3,75,0,
163,3,77,0,163,
3,79,0,163,3,
81,0,163,3,83,
0,163,3,85,0,
163,3,87,0,163,
3,89,0,163,3,
95,0,163,3,97,
0,163,3,99,0,
163,3,101,0,182,
12,1,3874,183,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,184,11,
1,93,0,185,4,
8,66,0,65,0,
83,0,69,0,3,
103,0,163,3,105,
0,163,3,107,0,
163,186,11,1,164,
0,166,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,187,11,
1,164,0,166,3,
99,0,163,3,101,
0,163,3,103,0,
163,3,105,0,163,
3,107,0,163,188,
11,1,164,0,166,
3,187,0,168,3,
112,0,161,3,51,
0,168,3,65,0,
161,3,79,0,161,
3,93,0,189,12,
1,1321,190,5,0,
191,11,1,251,0,
192,4,12,82,0,
66,0,82,0,65,
0,67,0,75,0,
3,107,0,161,3,
32,0,172,3,121,
0,193,12,1,2306,
194,5,63,3,109,
0,163,3,111,0,
163,3,113,0,163,
3,115,0,163,3,
117,0,163,3,119,
0,163,3,121,0,
195,12,1,2358,196,
5,63,3,109,0,
163,3,111,0,163,
3,113,0,163,3,
115,0,163,3,117,
0,163,3,119,0,
163,3,121,0,163,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
197,12,1,2525,198,
5,63,3,109,0,
163,3,111,0,163,
3,113,0,163,3,
115,0,163,3,117,
0,163,3,119,0,
163,3,121,0,163,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
163,3,100,0,163,
3,102,0,163,3,
104,0,163,3,106,
0,163,3,108,0,
163,3,110,0,163,
3,112,0,163,3,
114,0,163,3,116,
0,163,3,118,0,
163,3,120,0,163,
3,122,0,163,3,
49,0,163,3,51,
0,163,3,53,0,
163,3,55,0,163,
3,57,0,163,3,
65,0,163,3,67,
0,163,3,69,0,
163,3,71,0,163,
3,73,0,163,3,
75,0,163,3,77,
0,163,3,79,0,
163,3,81,0,163,
3,83,0,163,3,
85,0,163,3,87,
0,163,3,89,0,
163,3,95,0,163,
3,97,0,163,3,
99,0,163,3,101,
0,199,12,1,2581,
200,5,63,3,109,
0,163,3,111,0,
163,3,113,0,163,
3,115,0,163,3,
117,0,163,3,119,
0,163,3,121,0,
163,3,48,0,163,
3,50,0,163,3,
52,0,163,3,54,
0,163,3,56,0,
163,3,66,0,163,
3,68,0,163,3,
70,0,163,3,72,
0,163,3,74,0,
163,3,76,0,163,
3,78,0,163,3,
80,0,163,3,82,
0,163,3,84,0,
163,3,86,0,163,
3,88,0,163,3,
90,0,163,3,98,
0,163,3,100,0,
163,3,102,0,163,
3,104,0,163,3,
106,0,163,3,108,
0,163,3,110,0,
163,3,112,0,163,
3,114,0,163,3,
116,0,163,3,118,
0,163,3,120,0,
163,3,122,0,163,
3,49,0,163,3,
51,0,163,3,53,
0,163,3,55,0,
163,3,57,0,163,
3,65,0,163,3,
67,0,163,3,69,
0,163,3,71,0,
163,3,73,0,163,
3,75,0,163,3,
77,0,163,3,79,
0,163,3,81,0,
163,3,83,0,163,
3,85,0,163,3,
87,0,163,3,89,
0,163,3,95,0,
163,3,97,0,163,
3,99,0,163,3,
101,0,163,3,103,
0,201,12,1,2642,
202,5,63,3,109,
0,163,3,111,0,
163,3,113,0,163,
3,115,0,163,3,
117,0,163,3,119,
0,163,3,121,0,
163,3,48,0,163,
3,50,0,163,3,
52,0,163,3,54,
0,163,3,56,0,
163,3,66,0,163,
3,68,0,163,3,
70,0,163,3,72,
0,163,3,74,0,
163,3,76,0,163,
3,78,0,163,3,
80,0,163,3,82,
0,163,3,84,0,
163,3,86,0,163,
3,88,0,163,3,
90,0,163,3,98,
0,163,3,100,0,
163,3,102,0,163,
3,104,0,163,3,
106,0,163,3,108,
0,163,3,110,0,
163,3,112,0,163,
3,114,0,163,3,
116,0,163,3,118,
0,163,3,120,0,
163,3,122,0,163,
3,49,0,163,3,
51,0,163,3,53,
0,163,3,55,0,
163,3,57,0,163,
3,65,0,163,3,
67,0,163,3,69,
0,163,3,71,0,
163,3,73,0,163,
3,75,0,163,3,
77,0,163,3,79,
0,163,3,81,0,
163,3,83,0,163,
3,85,0,163,3,
87,0,163,3,89,
0,163,3,95,0,
163,3,97,0,163,
3,99,0,163,3,
101,0,163,3,103,
0,163,3,105,0,
203,12,1,2708,204,
5,63,3,109,0,
163,3,111,0,163,
3,113,0,163,3,
115,0,163,3,117,
0,163,3,119,0,
163,3,121,0,163,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
163,3,100,0,163,
3,102,0,163,3,
104,0,163,3,106,
0,163,3,108,0,
163,3,110,0,205,
12,1,2773,206,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,207,11,
1,8,208,11,1,
164,0,166,3,112,
0,163,3,114,0,
163,3,116,0,163,
3,118,0,163,3,
120,0,163,3,122,
0,163,3,49,0,
163,3,51,0,163,
3,53,0,163,3,
55,0,163,3,57,
0,163,3,65,0,
163,3,67,0,163,
3,69,0,163,3,
71,0,163,3,73,
0,163,3,75,0,
163,3,77,0,163,
3,79,0,163,3,
81,0,163,3,83,
0,163,3,85,0,
163,3,87,0,163,
3,89,0,163,3,
95,0,163,3,97,
0,163,3,99,0,
163,3,101,0,163,
3,103,0,163,3,
105,0,163,3,107,
0,163,209,11,1,
164,0,166,3,107,
0,163,210,11,1,
164,0,166,3,105,
0,163,3,107,0,
163,211,11,1,164,
0,166,3,103,0,
163,3,105,0,163,
3,107,0,163,212,
11,1,164,0,166,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,213,
12,1,2418,214,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,215,11,
1,55,216,11,1,
164,0,166,3,110,
0,163,3,112,0,
217,12,1,3058,218,
5,63,3,109,0,
163,3,111,0,163,
3,113,0,163,3,
115,0,163,3,117,
0,163,3,119,0,
163,3,121,0,163,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
163,3,100,0,163,
3,102,0,163,3,
104,0,163,3,106,
0,163,3,108,0,
163,3,110,0,163,
3,112,0,163,3,
114,0,163,3,116,
0,163,3,118,0,
163,3,120,0,163,
3,122,0,163,3,
49,0,163,3,51,
0,163,3,53,0,
163,3,55,0,163,
3,57,0,163,3,
65,0,163,3,67,
0,163,3,69,0,
163,3,71,0,163,
3,73,0,163,3,
75,0,163,3,77,
0,163,3,79,0,
163,3,81,0,163,
3,83,0,163,3,
85,0,163,3,87,
0,163,3,89,0,
163,3,95,0,163,
3,97,0,163,3,
99,0,163,3,101,
0,163,3,103,0,
163,3,105,0,163,
3,107,0,163,219,
11,1,74,220,11,
1,164,0,166,3,
114,0,163,3,116,
0,163,3,118,0,
163,3,120,0,163,
3,122,0,163,3,
49,0,163,3,51,
0,163,3,53,0,
163,3,55,0,163,
3,57,0,163,3,
65,0,163,3,67,
0,163,3,69,0,
163,3,71,0,163,
3,73,0,163,3,
75,0,163,3,77,
0,163,3,79,0,
163,3,81,0,163,
3,83,0,163,3,
85,0,163,3,87,
0,163,3,89,0,
163,3,95,0,163,
3,97,0,163,3,
99,0,163,3,101,
0,163,3,103,0,
163,3,105,0,163,
3,107,0,163,221,
11,1,164,0,166,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
163,3,100,0,163,
3,102,0,163,3,
104,0,163,3,106,
0,163,3,108,0,
163,3,110,0,163,
3,112,0,163,3,
114,0,163,3,116,
0,163,3,118,0,
163,3,120,0,163,
3,122,0,163,3,
49,0,163,3,51,
0,163,3,53,0,
163,3,55,0,163,
3,57,0,163,3,
65,0,163,3,67,
0,163,3,69,0,
163,3,71,0,163,
3,73,0,163,3,
75,0,163,3,77,
0,163,3,79,0,
163,3,81,0,163,
3,83,0,163,3,
85,0,163,3,87,
0,163,3,89,0,
163,3,95,0,163,
3,97,0,163,3,
99,0,163,3,101,
0,163,3,103,0,
163,3,105,0,163,
3,107,0,163,222,
11,1,164,0,166,
3,176,2,168,3,
58,15,168,3,88,
0,161,3,13,0,
172,3,102,0,161,
3,73,0,161,3,
116,0,223,12,1,
3252,224,5,63,3,
109,0,163,3,111,
0,163,3,113,0,
163,3,115,0,163,
3,117,0,163,3,
119,0,163,3,121,
0,163,3,48,0,
163,3,50,0,163,
3,52,0,163,3,
54,0,163,3,56,
0,163,3,66,0,
163,3,68,0,163,
3,70,0,163,3,
72,0,163,3,74,
0,163,3,76,0,
163,3,78,0,163,
3,80,0,163,3,
82,0,163,3,84,
0,163,3,86,0,
163,3,88,0,163,
3,90,0,163,3,
98,0,163,3,100,
0,163,3,102,0,
163,3,104,0,225,
12,1,3329,226,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,227,12,
1,3395,228,5,63,
3,109,0,163,3,
111,0,163,3,113,
0,163,3,115,0,
229,12,1,3459,230,
5,63,3,109,0,
163,3,111,0,163,
3,113,0,163,3,
115,0,163,3,117,
0,163,3,119,0,
163,3,121,0,163,
3,48,0,163,3,
50,0,163,3,52,
0,163,3,54,0,
163,3,56,0,163,
3,66,0,163,3,
68,0,163,3,70,
0,163,3,72,0,
163,3,74,0,163,
3,76,0,163,3,
78,0,163,3,80,
0,163,3,82,0,
163,3,84,0,163,
3,86,0,163,3,
88,0,163,3,90,
0,163,3,98,0,
163,3,100,0,163,
3,102,0,163,3,
104,0,163,3,106,
0,163,3,108,0,
163,3,110,0,163,
3,112,0,163,3,
114,0,163,3,116,
0,163,3,118,0,
163,3,120,0,163,
3,122,0,163,3,
49,0,163,3,51,
0,163,3,53,0,
163,3,55,0,163,
3,57,0,163,3,
65,0,163,3,67,
0,163,3,69,0,
163,3,71,0,163,
3,73,0,163,3,
75,0,163,3,77,
0,163,3,79,0,
163,3,81,0,163,
3,83,0,163,3,
85,0,163,3,87,
0,163,3,89,0,
163,3,95,0,163,
3,97,0,163,3,
99,0,163,3,101,
0,163,3,103,0,
163,3,105,0,163,
3,107,0,163,231,
11,1,119,0,232,
4,8,84,0,72,
0,73,0,83,0,
3,117,0,163,3,
119,0,163,3,121,
0,163,3,48,0,
163,3,50,0,163,
3,52,0,163,3,
54,0,163,3,56,
0,163,3,66,0,
163,3,68,0,163,
3,70,0,163,3,
72,0,163,3,74,
0,163,3,76,0,
163,3,78,0,163,
3,80,0,163,3,
82,0,163,3,84,
0,163,3,86,0,
163,3,88,0,163,
3,90,0,163,3,
98,0,163,3,100,
0,163,3,102,0,
163,3,104,0,163,
3,106,0,163,3,
108,0,163,3,110,
0,163,3,112,0,
163,3,114,0,163,
3,116,0,163,3,
118,0,163,3,120,
0,163,3,122,0,
163,3,49,0,163,
3,51,0,163,3,
53,0,163,3,55,
0,163,3,57,0,
163,3,65,0,163,
3,67,0,163,3,
69,0,163,3,71,
0,163,3,73,0,
163,3,75,0,163,
3,77,0,163,3,
79,0,163,3,81,
0,163,3,83,0,
163,3,85,0,163,
3,87,0,163,3,
89,0,163,3,95,
0,163,3,97,0,
163,3,99,0,163,
3,101,0,163,3,
103,0,163,3,105,
0,163,3,107,0,
163,233,11,1,164,
0,166,3,107,0,
163,234,11,1,164,
0,166,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,235,11,
1,164,0,166,3,
41,0,236,12,1,
1427,237,5,0,238,
11,1,241,0,239,
4,12,82,0,80,
0,65,0,82,0,
69,0,78,0,3,
55,0,168,3,69,
0,161,3,83,0,
161,3,97,0,161,
3,111,0,161,3,
36,0,168,3,125,
0,240,12,1,1215,
241,5,0,242,11,
1,231,0,243,4,
12,82,0,66,0,
82,0,65,0,67,
0,69,0,3,50,
0,168,3,197,1,
168,3,0,3,168,
3,78,0,161,3,
106,0,161,3,120,
0,161,3,45,0,
168,3,15,7,168,
3,59,0,244,12,
1,790,245,5,0,
246,11,1,221,0,
247,4,18,83,0,
69,0,77,0,73,
0,67,0,79,0,
76,0,79,0,78,
0,3,85,0,161,
3,74,0,161,3,
87,0,161,3,101,
0,161,3,136,4,
168,3,40,0,248,
12,1,1747,249,5,
0,250,11,1,236,
0,251,4,12,76,
0,80,0,65,0,
82,0,69,0,78,
0,3,187,1,168,
3,63,32,168,3,
54,0,168,3,68,
0,161,3,82,0,
161,3,171,0,168,
3,110,0,252,12,
1,4104,253,5,63,
3,109,0,163,3,
111,0,163,3,113,
0,163,3,115,0,
163,3,117,0,163,
3,119,0,163,3,
121,0,163,3,48,
0,163,3,50,0,
163,3,52,0,163,
3,54,0,163,3,
56,0,163,3,66,
0,163,3,68,0,
163,3,70,0,163,
3,72,0,163,3,
74,0,163,3,76,
0,163,3,78,0,
163,3,80,0,163,
3,82,0,163,3,
84,0,163,3,86,
0,163,3,88,0,
163,3,90,0,163,
3,98,0,163,3,
100,0,163,3,102,
0,163,3,104,0,
163,3,106,0,163,
3,108,0,163,3,
110,0,163,3,112,
0,163,3,114,0,
163,3,116,0,163,
3,118,0,163,3,
120,0,163,3,122,
0,163,3,49,0,
163,3,51,0,163,
3,53,0,163,3,
55,0,163,3,57,
0,163,3,65,0,
163,3,67,0,163,
3,69,0,163,3,
71,0,163,3,73,
0,163,3,75,0,
163,3,77,0,163,
3,79,0,163,3,
81,0,163,3,83,
0,163,3,85,0,
163,3,87,0,163,
3,89,0,163,3,
95,0,163,3,97,
0,163,3,99,0,
163,3,101,0,254,
12,1,4160,255,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,256,
12,1,4234,257,5,
63,3,109,0,163,
3,111,0,163,3,
113,0,163,3,115,
0,163,3,117,0,
163,3,119,0,163,
3,121,0,163,3,
48,0,163,3,50,
0,163,3,52,0,
163,3,54,0,163,
3,56,0,163,3,
66,0,163,3,68,
0,163,3,70,0,
163,3,72,0,163,
3,74,0,163,3,
76,0,163,3,78,
0,163,3,80,0,
163,3,82,0,163,
3,84,0,163,3,
86,0,163,3,88,
0,163,3,90,0,
163,3,98,0,163,
3,100,0,163,3,
102,0,163,3,104,
0,163,3,106,0,
163,3,108,0,163,
3,110,0,163,3,
112,0,163,3,114,
0,163,3,116,0,
163,3,118,0,163,
3,120,0,163,3,
122,0,163,3,49,
0,163,3,51,0,
163,3,53,0,163,
3,55,0,163,3,
57,0,163,3,65,
0,163,3,67,0,
163,3,69,0,163,
3,71,0,163,3,
73,0,163,3,75,
0,163,3,77,0,
163,3,79,0,163,
3,81,0,163,3,
83,0,163,3,85,
0,163,3,87,0,
163,3,89,0,163,
3,95,0,163,3,
97,0,163,3,99,
0,163,3,101,0,
163,3,103,0,163,
3,105,0,163,3,
107,0,163,258,11,
1,145,0,259,4,
6,78,0,69,0,
87,0,3,121,0,
163,3,48,0,163,
3,50,0,163,3,
52,0,163,3,54,
0,163,3,56,0,
163,3,66,0,163,
3,68,0,163,3,
70,0,163,3,72,
0,163,3,74,0,
163,3,76,0,163,
3,78,0,163,3,
80,0,163,3,82,
0,163,3,84,0,
163,3,86,0,163,
3,88,0,163,3,
90,0,163,3,98,
0,163,3,100,0,
163,3,102,0,163,
3,104,0,163,3,
106,0,163,3,108,
0,163,3,110,0,
163,3,112,0,163,
3,114,0,163,3,
116,0,163,3,118,
0,163,3,120,0,
163,3,122,0,163,
3,49,0,163,3,
51,0,163,3,53,
0,163,3,55,0,
163,3,57,0,163,
3,65,0,163,3,
67,0,163,3,69,
0,163,3,71,0,
163,3,73,0,163,
3,75,0,163,3,
77,0,163,3,79,
0,163,3,81,0,
163,3,83,0,163,
3,85,0,163,3,
87,0,163,3,89,
0,163,3,95,0,
163,3,97,0,163,
3,99,0,163,3,
101,0,163,3,103,
0,163,3,105,0,
163,3,107,0,163,
260,11,1,164,0,
166,3,103,0,163,
3,105,0,163,3,
107,0,163,261,11,
1,164,0,166,3,
49,0,168,3,77,
0,161,3,91,0,
262,12,1,1640,263,
5,0,264,11,1,
246,0,265,4,12,
76,0,66,0,82,
0,65,0,67,0,
75,0,3,40,32,
168,3,105,0,161,
3,75,0,161,3,
119,0,161,3,58,
0,266,12,1,684,
267,5,0,268,11,
1,216,0,269,4,
10,67,0,79,0,
76,0,79,0,78,
0,3,72,0,161,
3,0,224,168,3,
86,0,161,3,100,
0,161,3,114,0,
161,3,39,0,270,
12,1,896,271,5,
104,3,89,0,272,
12,1,897,273,5,
104,3,89,0,272,
3,178,0,272,3,
103,0,272,3,192,
0,272,3,117,0,
272,3,56,0,272,
3,70,0,272,3,
84,0,272,3,9,
0,272,3,98,0,
272,3,187,0,272,
3,112,0,272,3,
51,0,272,3,65,
0,272,3,79,0,
272,3,93,0,272,
3,107,0,272,3,
32,0,272,3,121,
0,272,3,176,2,
272,3,58,15,272,
3,88,0,272,3,
13,0,272,3,102,
0,272,3,73,0,
272,3,116,0,272,
3,41,0,272,3,
55,0,272,3,69,
0,272,3,83,0,
272,3,97,0,272,
3,111,0,272,3,
36,0,272,3,125,
0,272,3,50,0,
272,3,197,1,272,
3,0,3,272,3,
78,0,272,3,106,
0,272,3,120,0,
272,3,45,0,272,
3,15,7,272,3,
59,0,272,3,85,
0,272,3,74,0,
272,3,87,0,272,
3,101,0,272,3,
136,4,272,3,40,
0,272,3,187,1,
272,3,63,32,272,
3,54,0,272,3,
68,0,272,3,82,
0,272,3,171,0,
272,3,110,0,272,
3,49,0,272,3,
77,0,272,3,91,
0,272,3,40,32,
272,3,105,0,272,
3,75,0,272,3,
119,0,272,3,58,
0,272,3,72,0,
272,3,0,224,272,
3,86,0,272,3,
100,0,272,3,114,
0,272,3,39,0,
274,12,1,904,275,
5,0,276,11,1,
176,0,171,3,53,
0,272,3,67,0,
272,3,3,9,272,
3,81,0,272,3,
170,0,272,3,95,
0,272,3,109,0,
272,3,34,0,272,
3,96,6,272,3,
123,0,272,3,48,
0,272,3,41,32,
272,3,76,0,272,
3,1,0,272,3,
90,0,272,3,96,
33,272,3,104,0,
272,3,118,0,272,
3,43,0,272,3,
57,0,272,3,71,
0,272,3,160,0,
272,3,115,0,272,
3,10,0,272,3,
99,0,272,3,113,
0,272,3,52,0,
272,3,66,0,272,
3,80,0,272,3,
94,0,272,3,108,
0,272,3,33,0,
272,3,122,0,272,
3,59,15,272,0,
277,4,0,3,178,
0,272,3,103,0,
272,3,192,0,272,
3,117,0,272,3,
56,0,272,3,70,
0,272,3,84,0,
272,3,9,0,272,
3,98,0,272,3,
187,0,272,3,112,
0,272,3,51,0,
272,3,65,0,272,
3,79,0,272,3,
93,0,272,3,107,
0,272,3,32,0,
272,3,121,0,272,
3,176,2,272,3,
58,15,272,3,88,
0,272,3,13,0,
272,3,102,0,272,
3,73,0,272,3,
116,0,272,3,41,
0,272,3,55,0,
272,3,69,0,272,
3,83,0,272,3,
97,0,272,3,111,
0,272,3,36,0,
272,3,125,0,272,
3,50,0,272,3,
197,1,272,3,0,
3,272,3,78,0,
272,3,106,0,272,
3,120,0,272,3,
45,0,272,3,15,
7,272,3,59,0,
272,3,85,0,272,
3,74,0,272,3,
87,0,272,3,101,
0,272,3,136,4,
272,3,40,0,272,
3,187,1,272,3,
63,32,272,3,54,
0,272,3,68,0,
272,3,82,0,272,
3,171,0,272,3,
110,0,272,3,49,
0,272,3,77,0,
272,3,91,0,272,
3,40,32,272,3,
105,0,272,3,75,
0,272,3,119,0,
272,3,58,0,272,
3,72,0,272,3,
0,224,272,3,86,
0,272,3,100,0,
272,3,114,0,272,
3,39,0,274,3,
53,0,272,3,67,
0,272,3,3,9,
272,3,81,0,272,
3,170,0,272,3,
95,0,272,3,109,
0,272,3,34,0,
272,3,96,6,272,
3,123,0,272,3,
48,0,272,3,41,
32,272,3,76,0,
272,3,1,0,272,
3,90,0,272,3,
96,33,272,3,104,
0,272,3,118,0,
272,3,43,0,272,
3,57,0,272,3,
71,0,272,3,160,
0,272,3,115,0,
272,3,10,0,272,
3,99,0,272,3,
113,0,272,3,52,
0,272,3,66,0,
272,3,80,0,272,
3,94,0,272,3,
108,0,272,3,33,
0,272,3,122,0,
272,3,59,15,272,
278,11,1,256,0,
171,3,53,0,168,
3,67,0,161,3,
3,9,168,3,81,
0,161,3,170,0,
168,3,95,0,161,
3,109,0,161,3,
34,0,279,12,1,
368,280,5,104,3,
89,0,281,12,1,
369,282,5,104,3,
89,0,281,3,178,
0,281,3,103,0,
281,3,192,0,281,
3,117,0,281,3,
56,0,281,3,70,
0,281,3,84,0,
281,3,9,0,281,
3,98,0,281,3,
187,0,281,3,112,
0,281,3,51,0,
281,3,65,0,281,
3,79,0,281,3,
93,0,281,3,107,
0,281,3,32,0,
281,3,121,0,281,
3,176,2,281,3,
58,15,281,3,88,
0,281,3,13,0,
281,3,102,0,281,
3,73,0,281,3,
116,0,281,3,41,
0,281,3,55,0,
281,3,69,0,281,
3,83,0,281,3,
97,0,281,3,111,
0,281,3,36,0,
281,3,125,0,281,
3,50,0,281,3,
197,1,281,3,0,
3,281,3,78,0,
281,3,106,0,281,
3,120,0,281,3,
45,0,281,3,15,
7,281,3,59,0,
281,3,85,0,281,
3,74,0,281,3,
87,0,281,3,101,
0,281,3,136,4,
281,3,40,0,281,
3,187,1,281,3,
63,32,281,3,54,
0,281,3,68,0,
281,3,82,0,281,
3,171,0,281,3,
110,0,281,3,49,
0,281,3,77,0,
281,3,91,0,281,
3,40,32,281,3,
105,0,281,3,75,
0,281,3,119,0,
281,3,58,0,281,
3,72,0,281,3,
0,224,281,3,86,
0,281,3,100,0,
281,3,114,0,281,
3,39,0,281,3,
53,0,281,3,67,
0,281,3,3,9,
281,3,81,0,281,
3,170,0,281,3,
95,0,281,3,109,
0,281,3,34,0,
283,12,1,373,284,
5,0,285,11,1,
196,0,171,3,96,
6,281,3,123,0,
281,3,48,0,281,
3,41,32,281,3,
76,0,281,3,1,
0,281,3,90,0,
281,3,96,33,281,
3,104,0,281,3,
118,0,281,3,43,
0,281,3,57,0,
281,3,71,0,281,
3,160,0,281,3,
115,0,281,3,10,
0,281,3,99,0,
281,3,113,0,281,
3,52,0,281,3,
66,0,281,3,80,
0,281,3,94,0,
281,3,108,0,281,
3,33,0,281,3,
122,0,281,3,59,
15,281,0,277,3,
178,0,281,3,103,
0,281,3,192,0,
281,3,117,0,281,
3,56,0,281,3,
70,0,281,3,84,
0,281,3,9,0,
281,3,98,0,281,
3,187,0,281,3,
112,0,281,3,51,
0,281,3,65,0,
281,3,79,0,281,
3,93,0,281,3,
107,0,281,3,32,
0,281,3,121,0,
281,3,176,2,281,
3,58,15,281,3,
88,0,281,3,13,
0,281,3,102,0,
281,3,73,0,281,
3,116,0,281,3,
41,0,281,3,55,
0,281,3,69,0,
281,3,83,0,281,
3,97,0,281,3,
111,0,281,3,36,
0,281,3,125,0,
281,3,50,0,281,
3,197,1,281,3,
0,3,281,3,78,
0,281,3,106,0,
281,3,120,0,281,
3,45,0,281,3,
15,7,281,3,59,
0,281,3,85,0,
281,3,74,0,281,
3,87,0,281,3,
101,0,281,3,136,
4,281,3,40,0,
281,3,187,1,281,
3,63,32,281,3,
54,0,281,3,68,
0,281,3,82,0,
281,3,171,0,281,
3,110,0,281,3,
49,0,281,3,77,
0,281,3,91,0,
281,3,40,32,281,
3,105,0,281,3,
75,0,281,3,119,
0,281,3,58,0,
281,3,72,0,281,
3,0,224,281,3,
86,0,281,3,100,
0,281,3,114,0,
281,3,39,0,281,
3,53,0,281,3,
67,0,281,3,3,
9,281,3,81,0,
281,3,170,0,281,
3,95,0,281,3,
109,0,281,3,34,
0,283,3,96,6,
281,3,123,0,281,
3,48,0,281,3,
41,32,281,3,76,
0,281,3,1,0,
281,3,90,0,281,
3,96,33,281,3,
104,0,281,3,118,
0,281,3,43,0,
281,3,57,0,281,
3,71,0,281,3,
160,0,281,3,115,
0,281,3,10,0,
281,3,99,0,281,
3,113,0,281,3,
52,0,281,3,66,
0,281,3,80,0,
281,3,94,0,281,
3,108,0,281,3,
33,0,281,3,122,
0,281,3,59,15,
281,286,11,1,256,
0,171,3,96,6,
168,3,123,0,287,
12,1,1534,288,5,
0,289,11,1,226,
0,290,4,12,76,
0,66,0,82,0,
65,0,67,0,69,
0,3,48,0,168,
3,41,32,168,3,
76,0,161,3,1,
0,168,3,90,0,
161,3,96,33,168,
3,104,0,161,3,
118,0,161,3,43,
0,168,3,57,0,
168,3,71,0,161,
3,160,0,168,3,
115,0,161,3,10,
0,291,12,1,2176,
292,5,0,293,11,
1,2,0,277,3,
99,0,161,3,113,
0,161,3,52,0,
168,3,66,0,161,
3,80,0,161,3,
94,0,168,3,108,
0,161,3,33,0,
168,3,122,0,161,
3,59,15,168,0,
277,294,5,13,185,
295,10,185,239,296,
10,239,171,297,10,
171,269,298,10,269,
290,299,10,290,166,
300,10,166,232,301,
10,232,265,302,10,
265,251,303,10,251,
192,304,10,192,247,
305,10,247,259,306,
10,259,243,307,10,
243,0};
 new Tfactory(this,"BASE",new TCreator(BASE_factory));
 new Tfactory(this,"RPAREN",new TCreator(RPAREN_factory));
 new Tfactory(this,"ANY",new TCreator(ANY_factory));
 new Tfactory(this,"COLON",new TCreator(COLON_factory));
 new Tfactory(this,"LBRACE",new TCreator(LBRACE_factory));
 new Tfactory(this,"ID",new TCreator(ID_factory));
 new Tfactory(this,"THIS",new TCreator(THIS_factory));
 new Tfactory(this,"LBRACK",new TCreator(LBRACK_factory));
 new Tfactory(this,"LPAREN",new TCreator(LPAREN_factory));
 new Tfactory(this,"RBRACK",new TCreator(RBRACK_factory));
 new Tfactory(this,"SEMICOLON",new TCreator(SEMICOLON_factory));
 new Tfactory(this,"NEW",new TCreator(NEW_factory));
 new Tfactory(this,"RBRACE",new TCreator(RBRACE_factory));
}
public static object BASE_factory(Lexer yyl) { return new BASE(yyl);}
public static object RPAREN_factory(Lexer yyl) { return new RPAREN(yyl);}
public static object ANY_factory(Lexer yyl) { return new ANY(yyl);}
public static object COLON_factory(Lexer yyl) { return new COLON(yyl);}
public static object LBRACE_factory(Lexer yyl) { return new LBRACE(yyl);}
public static object ID_factory(Lexer yyl) { return new ID(yyl);}
public static object THIS_factory(Lexer yyl) { return new THIS(yyl);}
public static object LBRACK_factory(Lexer yyl) { return new LBRACK(yyl);}
public static object LPAREN_factory(Lexer yyl) { return new LPAREN(yyl);}
public static object RBRACK_factory(Lexer yyl) { return new RBRACK(yyl);}
public static object SEMICOLON_factory(Lexer yyl) { return new SEMICOLON(yyl);}
public static object NEW_factory(Lexer yyl) { return new NEW(yyl);}
public static object RBRACE_factory(Lexer yyl) { return new RBRACE(yyl);}
public override TOKEN OldAction(Lexer yym,string yytext, int action, ref bool reject) {
  switch(action) {
  case -1: break;
   case 74: { yytext="(("+((cs0tokens)yym).Out+")yyq)"; return new ANY(yym); }
	  break;
   case 55: { yytext="(("+((cs0tokens)yym).Out+")yym)"; return new ANY(yym); }
	  break;
   case 8: { yytext ="yym.yy_begin"; return new ANY(yym); }
	  break;
   case 2: ;
	  break;
  }
  return null;
}}
public class cs0tokens:Lexer {
public cs0tokens():base(new yycs0tokens(new ErrorHandler(false))) {}
public cs0tokens(ErrorHandler eh):base(new yycs0tokens(eh)) {}
public cs0tokens(Tokens tks):base(tks){}

	public string Out;

 }
}
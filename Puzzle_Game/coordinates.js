var coords = new Float32Array( [   0.0,  0.0,0.0, //1
                                       0.0,  0.25,0.0,
                                       0.25, 0.25,0.0,
                                       0.25,  0.0,0.0,
									   
									   0.25,  0.0,0.0, //5
                                       0.25,  0.25,0.0,
                                       0.5, 0.25,0.0,
                                       0.5,  0.0,0.0,
									   
									    0.5,  0.0,0.0,//9
                                       0.5,  0.25,0.0,
                                       0.75, 0.25,0.0,
                                       0.75,  0.0,0.0,
									   
									   
									   0.75,  0.0, 0.0,//13
                                       0.75,  0.25,0.0,
                                       1.0,   0.25,0.0,
                                       1.0,    0.0,0.0,
									   
									   
									   0.0,  0.25,0,//17
                                       0.0,  0.5,0,
                                       .25, 0.5,0,
                                       .25,  0.25,0,
									   
									    0.25,  0.25,0,//21
                                       0.25,  0.5,0,
                                       0.5, 0.5,0,
                                       0.5,  0.25,0,
									      
										  
									    0.5,  0.25,0,//25
                                       0.5,  0.5,0,
                                       0.75, 0.5,0,
                                       0.75,  0.25,0,
									   
									   0.75, 0.25,0,//29
									   0.75, 0.5,0,
									   1.0,0.5,0,
									   1.0,0.25,0,
									   
									   	   //3rd
									   
									   	0.0,  0.5,0,//33
                                       0.0,  0.75,0,
                                       .25, 0.75,0,
                                       .25,  0.5,0,
									 
									 
									   0.25,  0.5,0,//37
                                       0.25,  0.75,0,
                                       .5, 0.75,0,
                                       .5,  0.5,0,
									   
									   0.5,  0.5,0,//41
                                       0.5,  0.75,0,
                                       0.75, 0.75,0,
                                       0.75,  0.5,0,
									   
									   0.75, 0.5,0,//45
									   0.75, 0.75,0,
									   1.0,0.75,0,
									   1.0,0.5,0,
									   
									    
									   //4th
									   
									   	0.0,  0.75,0,//49
                                       0.0,  1.0,0,
                                       .25, 1.0,0,
                                       .25,  0.75,0,
									 
									 
									   0.25,  0.75,0,//53
                                       0.25,  1.0,0,
                                       .5, 1.0,0,
                                       .5,  0.75,0,
									   
									   0.5,  0.75,0,//57
                                       0.5,  1.0,0,
                                       0.75, 1.0,0,
                                       0.75,  0.75,0,
									   
									   0.75, 0.75,0,//61
									   0.75, 1.0,0,
									   1.0,  1.0,0,
									   1.0,0.75,0,									
									
                                    ] );
    var texCoords = new Float32Array( [ 
									   0.0, 0.0,
									   0.0, 0.0,
									   0.0,  0.0,
									   0.0,0.0,
									   
									      
								       0.25,  0.0,//8
                                       0.25,  0.25,
                                       0.5, 0.25,
                                       0.5,  0.0,
									   
									   
								       0.5,  0.0,//16
                                       0.5,  0.25,
                                       0.75, 0.25,
                                       0.75,  0.0,
									   
									   0.75,  0.0,//24
                                       0.75,  0.25,
                                       1.0, 0.25,
                                       1.0,  0.0,
									   
									    //2nd
										
										0.0,  0.25,//32
                                       0.0,  0.5,
                                       .25, 0.5,
                                       .25,  0.25,
									 
									 
									   0.25,  0.25,//40
                                       0.25,  0.5,
                                       .5, 0.5,
                                       .5,  0.25,
									   
									   0.5,  0.25,//48
                                       0.5,  0.5,
                                       0.75, 0.5,
                                       0.75,  0.25,
									   
									   0.75, 0.25,//56
									   0.75, 0.5,
									   1.0,0.5,
									   1.0,0.25,
									   
									   
									   //3rd
									   
									   	0.0,  0.5,//64
                                       0.0,  0.75,
                                       .25, 0.75,
                                       .25,  0.5,
									 
									 
									   0.25,  0.5,//72
                                       0.25,  0.75,
                                       .5, 0.75,
                                       .5,  0.5,
									   
									   0.5,  0.5,//80
                                       0.5,  0.75,
                                       0.75, 0.75,
                                       0.75,  0.5,
									   
									   0.75, 0.5,//88
									   0.75, 0.75,
									   1.0,0.75,
									   1.0,0.5,
									   
									   
									   //4th
									   
									   	0.0,  0.75,//96
                                       0.0,  1.0,
                                       .25, 1.0,
                                       .25,  0.75,
									 
									 
									   0.25,  0.75,//
                                       0.25,  1.0,
                                       .5, 1.0,
                                       .5,  0.75,
									   
									   0.5,  0.75,
                                       0.5,  1.0,
                                       0.75, 1.0,
                                       0.75,  0.75,
									   
									   0.75, 0.75,
									   0.75, 1.0,
									   1.0,  1.0,
									   1.0,0.75,] );
   var texCoordsB = new Float32Array( [ 
									   0.0, 0.0,
									   0.0, 0.0,
									   0.0,  0.0,
									   0.0,0.0,
									   
									      
								       0.25,  0.0,//8
                                       0.25,  0.25,
                                       0.5, 0.25,
                                       0.5,  0.0,
									   
									   
								       0.5,  0.0,//16
                                       0.5,  0.25,
                                       0.75, 0.25,
                                       0.75,  0.0,
									   
									   0.75,  0.0,//24
                                       0.75,  0.25,
                                       1.0, 0.25,
                                       1.0,  0.0,
									   
									    //2nd
										
										0.0,  0.25,//32
                                       0.0,  0.5,
                                       .25, 0.5,
                                       .25,  0.25,
									 
									 
									   0.25,  0.25,//40
                                       0.25,  0.5,
                                       .5, 0.5,
                                       .5,  0.25,
									   
									   0.5,  0.25,//48
                                       0.5,  0.5,
                                       0.75, 0.5,
                                       0.75,  0.25,
									   
									   0.75, 0.25,//56
									   0.75, 0.5,
									   1.0,0.5,
									   1.0,0.25,
									   
									   
									   //3rd
									   
									   	0.0,  0.5,//64
                                       0.0,  0.75,
                                       .25, 0.75,
                                       .25,  0.5,
									 
									 
									   0.25,  0.5,//72
                                       0.25,  0.75,
                                       .5, 0.75,
                                       .5,  0.5,
									   
									   0.5,  0.5,//80
                                       0.5,  0.75,
                                       0.75, 0.75,
                                       0.75,  0.5,
									   
									   0.75, 0.5,//88
									   0.75, 0.75,
									   1.0,0.75,
									   1.0,0.5,
									   
									   
									   //4th
									   
									   	0.0,  0.75,//96
                                       0.0,  1.0,
                                       .25, 1.0,
                                       .25,  0.75,
									 
									 
									   0.25,  0.75,//
                                       0.25,  1.0,
                                       .5, 1.0,
                                       .5,  0.75,
									   
									   0.5,  0.75,
                                       0.5,  1.0,
                                       0.75, 1.0,
                                       0.75,  0.75,
									   
									   0.75, 0.75,
									   0.75, 1.0,
									   1.0,  1.0,
									   1.0,0.75,] );
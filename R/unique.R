Unique <- function (input) {
  
  if(!(is.vector(input)|is.list(input))){
    print("Expected input type: Vector/List")
    stop()
  }#First, check if input is expected type
  
  count <- 1
  
  if(is.vector(input)){output <- vector(class(input))}
  if(is.list(input)){output <- list()}
  
  for(i in input){
    
    if(length(output[as.character(output)==as.character(i)]) == 0){ # Had to cast to Char. to make this work
      output <- c(output, i)
    }
    
  }
  
  return(output)
  
}
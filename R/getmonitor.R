getmonitor <- function(id, directory, summarize = FALSE) {
  
  ###First, validate the values input for 'id' as 'directory'###
  if(!is.numeric(id) && !is.integer(id) && !is.character(id)){
    stop("'id' must be of type numeric, integer, or character")
  }#if
  if(length(id) != 1){
    stop("'id' must be a vector of length 1")
  }#if
  id <- as.integer(id) #Make sure id is a whole number
  if(id < 1 || id > 332){
    stop("Possible values of id are whole numbers 1-332")
  }#if
  if(length(directory) != 1){
    stop("'directory' should be a string value representing the path to the monitor data")
  }#if
  
  ###Next, create the file name for the requested data using 'id'###
  if(id < 10){
    filename <- paste(directory, "\\", "00", as.character(id), ".csv", sep="")
  }#if
  else if(id < 99){
    filename <- paste(directory, "\\", "0", as.character(id), ".csv", sep="")
  }#else if
  else{
    filename <- paste(directory, "\\", as.character(id), ".csv", sep="")
  }#else
  data <- read.csv(filename)
  
  ###Now, we want to summerize the data, if 'summarize' is set to true###
  if(summarize == TRUE){
    print(summary(data))
  }
  
  ###Finally, we return the data frame 'data'
  data
}
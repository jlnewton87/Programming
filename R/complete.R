complete <- function(directory, id = 1:332) {
  ## 'directory' is a character vector of length 1 indicating
  ## the location of the CSV files
  
  ## 'id' is an integer vector indicating the monitor ID numbers
  ## to be used
  
  ## Return a data frame of the form:
  ## id nobs
  ## 1  117
  ## 2  1041
  ## ...
  ## where 'id' is the monitor ID number and 'nobs' is the
  ## number of complete cases
  ids <- c()
  nobs <- c()
  
  for(num in id){
    if(num < 10){
      filename <- paste(directory, "\\", "00", as.character(num), ".csv", sep="")
    }#if
    else if(num < 100){
      filename <- paste(directory, "\\", "0", as.character(num), ".csv", sep="")
    }#else if
    else{
      filename <- paste(directory, "\\", as.character(num), ".csv", sep="")
    }#else
    x <- read.csv(filename)
    y <- x[complete.cases(x, x$sulfate), ]
    y = y[complete.cases(y, y$nitrate), ]
    ids <- c(ids, num)
    nobs <- c(nobs, nrow(y))

  }
  data.frame(id = ids, nobs = nobs)
}

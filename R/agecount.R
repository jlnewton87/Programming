agecount <- function(age = NULL) {
  ## Check that "age" is non-NULL; else throw error
  if(length(age) == 0){stop("You must supply an age")}
  ## Read "homicides.txt" data file
  homicides <- readLines("homicides.txt")
  ## Extract ages of victims; ignore records where no age is given
  ageRegEx <- paste(as.character(age), " years old", sep="")
  i <- grep(ageRegEx, homicides)
  ## Return integer containing count of homicides for that age
  return(length(i))
}